using BarberShopCodeFirstFromDB;
using EFControllerUtilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShopApp
{
    public partial class BarberShopAdminForm : Form
    {

        /// <summary>
        ///  author: Steven 
        ///  id:300329089
        ///  Thus is the Admin form and has all the admin controls
        /// </summary>

        public BarberShopAdminForm()
        {
            InitializeComponent();
            this.Load += (s, e) => BarberShopAdminForm_Load();
        }


        private void BarberShopAdminForm_Load()
        {
            InitializeDataGridView<Shop>(dataGridViewShop, "Barber_Avail");
            InitializeDataGridView<Barber>(dataGridViewBarber, "Barber_shifts");
            InitializeDataGridView<Shift>(dataGridViewShifts, "Barber_shifts");
            
            LoadBarberShopAvailability();
            LoadAppointments();
            PopulateComboBoxStatus();
        }

        private void PopulateComboBoxStatus()
        {
            var listStatus = Controller<BarberShopEntities, Status>.SetBindingList()
                             .Select(x => x.status_id);
            foreach(var item in listStatus)
                comboBoxStatus.Items.Add(item);
        }

        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            InnitDatagridviewProperties(gridView);

            // set the handler used to delete an item. Note use of generics.

            //gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);

            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);


            gridView.DataSource = Controller<BarberShopEntities, T>.SetBindingList();


            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;

        }


        private void LoadBarberShopAvailability()
        {
            var barberShopAvailability = Controller<BarberShopEntities, Barber_Avail>.GetEntitiesWithIncluded("Barber_shifts");
            var listBaberAssignment = (
                                      from barberShopAvail in barberShopAvailability
                                      select new
                                      {
                                          shop_id = barberShopAvail.shop_id,
                                          barber_id = barberShopAvail.barber_id,
                                          shift_id = barberShopAvail.shift_id,
                                          price = barberShopAvail.Barber_shifts.price,
                                          Shop = barberShopAvail.Shop,
                                          Barber_shifts = barberShopAvail.Barber_shifts
                                      }).ToList();
            InnitDatagridviewProperties(dataGridViewBarberShiftAvail);
            dataGridViewBarberShiftAvail.DataSource = listBaberAssignment;
            dataGridViewBarberShiftAvail.Columns["Shop"].Visible = false;
            dataGridViewBarberShiftAvail.Columns["Barber_shifts"].Visible = false;
        }

        private void LoadAppointments()
        {
            var appointments = Controller<BarberShopEntities, Appointment>.GetEntitiesWithIncluded("Haircut", "Status", "User", "Barber_Avail");
            appointments = Controller<BarberShopEntities, Appointment>.GetEntitiesWithIncluded("Haircut", "Status", "User");
            appointments = Controller<BarberShopEntities, Appointment>.GetEntitiesWithIncluded("Haircut", "Status");
            appointments = Controller<BarberShopEntities, Appointment>.GetEntitiesWithIncluded("Haircut");
            appointments= Controller<BarberShopEntities, Appointment>.SetBindingList();
            var listAppointments = (
                                      from appointment in appointments
                                      select new
                                      {
                                          id = appointment.appointment_id,
                                          barber_id = appointment.Barber_Avail.barber_id,
                                          //barber_name= appointment.Barber_Avail.Barber_shifts.Barber.barber_name,
                                          shift_id = appointment.Barber_Avail.shift_id,
                                          haircut= appointment.Haircut.description,
                                          user_id = appointment.User.user_id,
                                          user_name= appointment.User.user_name,
                                          price = appointment.Barber_Avail.Barber_shifts.price+appointment.Haircut.price,
                                          time=appointment.appointment_time,
                                          payment_status=appointment.payment_status,
                                          review= appointment.review,
                                          status=appointment.status_id
                                      }).ToList();
            InnitDatagridviewProperties(dataGridViewAppointments);
            dataGridViewAppointments.DataSource = listAppointments;
            dataGridViewAppointments.Columns["Haircut"].Visible = false;
            dataGridViewAppointments.Columns["Status"].Visible = false;
            //dataGridViewAppointments.Columns["User"].Visible = false;
            //dataGridViewAppointments.Columns["Barber_Avail"].Visible = false;
        }



        private void InnitDatagridviewProperties(DataGridView gridView)
        {
            gridView.AllowUserToAddRows = false;

            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Catch any gridview data error, log to debug and cancel any event.
        /// Should not happen, as all of our gridviews are readonly. Might show up when items
        /// are deleted.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="e"></param>
        private void HandleDataError<T>(DataGridView dataGridView, DataGridViewDataErrorEventArgs e) where T : class
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + dataGridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }
        /// <summary>
        /// Handler to delete the selected row (item) from a gridview and update the DB.
        /// Update the gridview with the revised data from the DB, as well
        /// as the customer orders report gridview.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView used to delete the row</param>
        /// <param name="e"></param>
        /*private void DeletingRow<T>(DataGridView dataGridView, DataGridViewRowCancelEventArgs e) where T : class
        {
            // get the item

            T item = e.Row.DataBoundItem as T;
            if (typeof(T) == typeof(Course))
            {
                var departments = Controller<StudentRegistrationEntities, Department>.GetEntities();
                var department = departments
                    .Where(d => d.DepartmentId == (item as Course).DepartmentId).FirstOrDefault();
                (item as Course).Department = department;
            }

            Debug.WriteLine("DeletingRow " + e.Row.Index + " entity " + typeof(T) + " " + item);

            // Delete the item in the DB. No need to worry about dependencies, as there is no context!
            // Just let cascade delete take care of it.

            Controller<StudentRegistrationEntities, T>.DeleteEntity(item);
            dataGridView.Refresh();

            // The Orders table always gets updated, this forces the update from the DB.
            // It will show the effect of cascade delete in the DB.

        }*/
    }
}
