using BarberShopCodeFirstFromDB;
using EFControllerUtilities;
using System;
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
    public partial class UserHomepage : Form
    {
        public UserHomepage()
        {
            InitializeComponent();
            this.Text = "User Homepage";
            this.Load += (s, e) => UserHomepageMainForm_Load();

            AddOrUpdateUserForm addUpdateUserForm = new AddOrUpdateUserForm();
            buttonAddUpdateUser.Click += (s, ee) => AddOrUpdateForm<User>(dataGridViewUserDetails, addUpdateUserForm);

            buttonAddNewAppointment.Click += (s, ee) => AddAppointmentForm();


        }
        /// <summary>
        /// showing the add appointment form
        /// </summary>
        private void AddAppointmentForm()
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.Show();
            Close();
        }
        /// <summary>
        /// loading the user homepage
        /// </summary>
        private void UserHomepageMainForm_Load()
        {
            InitializeDataGridView<User>(dataGridViewUserDetails, "Appointments");
            InitializeDataGridView<Appointment>(dataGridViewAppointmentDetails, "Haircut", "Status", "User", "Barber_Avail", "Review");
        }

        /// <summary>
        /// add or update form as a generic method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="addUpdateForm"></param>
        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form addUpdateForm) where T : class
        {
            var output = addUpdateForm.ShowDialog();

            // form has closed

            if (output == DialogResult.OK)
            {
                // reload the db and update the gridview
                dataGridView.DataSource = Controller<BarberShopEntities, T>.SetBindingList();
                dataGridView.Refresh();
            }

            // do not close, as the form object will be disposed, 
            // just hide the form (make it invisible). 
            // 
            // when the inputForm is opened again (ShowDialog()), the Load event will fire
            //  and the form will be reinitialized

            addUpdateForm.Hide();
        }
        /// <summary>
        /// generic method to show datagridview from database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            InnitDatagridviewProperties(gridView);

            // set the handler used to delete an item. Note use of generics.

           gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);

            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);


            gridView.DataSource = Controller<BarberShopEntities, T>.SetBindingList();


            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
        }

        /// <summary>
        /// initialize the datagridview
        /// </summary>
        /// <param name="gridView"></param>
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
        private void DeletingRow<T>(DataGridView dataGridView, DataGridViewRowCancelEventArgs e) where T : class
        {
            // get the item

            T item = e.Row.DataBoundItem as T;

            Debug.WriteLine("DeletingRow " + e.Row.Index + " entity " + typeof(T) + " " + item);

            // Delete the item in the DB. No need to worry about dependencies, as there is no context!
            // Just let cascade delete take care of it.

            Controller<BarberShopEntities, T>.DeleteEntity(item);
            dataGridView.Refresh();

            // The Orders table always gets updated, this forces the update from the DB.
            // It will show the effect of cascade delete in the DB.

        }
    }
}
