using BarberShopCodeFirstFromDB;
using DataTableAccessLayer;
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
        /// 
        // field to keep the access layer field

        private SqlDataTableAccessLayer barberShopDB;

        // dataset will hold all tables being used

        private DataSet barberShopDataSet;

        public BarberShopAdminForm()
        {
            InitializeComponent();
            this.Load += (s, e) => BarberShopAdminForm_Load();
            PopulateComboBoxStatus();

            // get a new access layer and dataset

            barberShopDB = new SqlDataTableAccessLayer();

            barberShopDataSet = new DataSet()
            {
                // must be named for backup purposes

                DataSetName = "BarberShopDataSet",
            };

            // YOUR CODE HERE
            string connectionString = barberShopDB.GetConnectionString("BarberShopConnection");

            barberShopDB.OpenConnection(connectionString);

            buttonAssign.Click += ButtonAssign_Click;

            // add button event handlers for database backup to xml
            buttonBackup.Click += ButtonBackup_Click;
            buttonRestore.Click += ButtonRestore_Click;
            comboBoxStatus.SelectedIndexChanged += ComboBoxStatus_SelectedIndexChanged;
            buttonChangeStatus.Click += ButtonChangeStatus_Click;

            AddOrUpdateBarberForm addOrUpdateBarber = new AddOrUpdateBarberForm();
            AddOrUpdateShops addOrUpdateShops = new AddOrUpdateShops();

            this.buttonAddUpdateShop.Click += (s, ee) =>  AddOrUpdateForm<Shop>(dataGridViewShop, addOrUpdateShops);
            this.buttonAddUpdateBarber.Click += (s, ee) => AddOrUpdateForm<Barber>(dataGridViewBarber, addOrUpdateBarber);


            // ensure that the connection to the db is closed
            this.FormClosing += (s, e) => barberShopDB.CloseConnection();
        }

        /// <summary>
        /// General method to load child forms
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
                // update gridview
            }

            // do not close, as the form object will be disposed, 
            // just hide the form (make it invisible). 
            // 
            // when the inputForm is opened again (ShowDialog()), the Load event will fire
            //  and the form will be reinitialized

            addUpdateForm.Hide();
        }

        /// <summary>
        /// handles click event of the button change status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeStatus_Click(object sender, EventArgs e)
        {
            if (comboBoxNewStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Select new Status");
            }
            else if (dataGridViewAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select row from Appointments");
            }
            else if (dataGridViewAppointments.CurrentRow.Cells["status"].Value.ToString().Trim() == comboBoxNewStatus.SelectedItem.ToString().Trim())
            {
                MessageBox.Show("Its already in the same Status");
            }
            else {
                int appointmentId = Convert.ToInt16(dataGridViewAppointments.CurrentRow.Cells["id"].Value);
                /*Appointment appointment = Controller<BarberShopEntities, Appointment>.GetEntitiesWithIncluded("Haircut", "Status", "User", "Barber_Avail").Where(x=>x.appointment_id== appointmentId).FirstOrDefault() as Appointment;
                var status = Controller<BarberShopEntities, Status>.GetEntities().Where(x => x.status_id == comboBoxNewStatus.SelectedItem.ToString()).FirstOrDefault();
                appointment.status_id = status.status_id;
                appointment.Status = status;*/
                Appointment appointment = Controller<BarberShopEntities, Appointment>.GetEntities().Where(x => x.appointment_id == appointmentId).FirstOrDefault() as Appointment;
                var status = Controller<BarberShopEntities, Status>.GetEntities().Where(x => x.status_id == comboBoxNewStatus.SelectedItem.ToString()).FirstOrDefault();
                appointment.status_id = status.status_id.ToString().Trim();
                if (!Controller<BarberShopEntities, Appointment>.UpdateEntity(appointment))
                {
                    MessageBox.Show("Status update failed");
                }
                else
                {
                    MessageBox.Show("Status updated successfully");
                }
                if (comboBoxStatus.SelectedIndex != -1)
                    LoadAppointments(comboBoxStatus.SelectedItem.ToString());
                else 
                    LoadAppointments();
            }
        }

        /// <summary>
        /// handles on selection change of combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAppointments(comboBoxStatus.SelectedItem.ToString());
        }

        /// <summary>
        /// Called when button Assign barber shop and /shift is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAssign_Click(object sender, EventArgs e)
        {
            int price = 0;
            if (String.IsNullOrEmpty(textBoxPrice.Text) || !int.TryParse(textBoxPrice.Text, out price)) {
                MessageBox.Show("Enter proper price!");
                return;
            }
            else if (dataGridViewBarber.SelectedRows.Count > 0 && dataGridViewShop.SelectedRows.Count > 0 && dataGridViewShifts.SelectedRows.Count > 0)
            {
                var barberId = dataGridViewBarber.CurrentRow.Cells["barber_id"].Value;
                var shopId = dataGridViewShop.CurrentRow.Cells["shop_id"].Value;
                var shiftId = dataGridViewShifts.CurrentRow.Cells["shift_id"].Value;
                var barberAssign = Controller<BarberShopEntities, Barber_Avail>.GetEntities(it => it.barber_id == Convert.ToInt32(barberId) && it.shop_id == Convert.ToInt32(shopId) && it.shift_id == Convert.ToInt32(shiftId)).FirstOrDefault();
                if (barberAssign != null)
                {
                    MessageBox.Show("Could not assign shift and shop to barber as it already exist!");
                    return;
                }
                Barber_shifts barber_Shifts = new Barber_shifts();
                barber_Shifts.barber_id = Convert.ToInt32(barberId);
                barber_Shifts.shift_id = Convert.ToInt32(shiftId);
                barber_Shifts.price = price;
                //barber_Shifts.Barber = Controller<BarberShopEntities, Barber>.GetEntities(it => it.barber_id == Convert.ToInt32(barberId)).FirstOrDefault();
                //barber_Shifts.Shift = Controller<BarberShopEntities, Shift>.GetEntities(it => it.shift_id == Convert.ToInt32(shiftId)).FirstOrDefault();
                if (Controller<BarberShopEntities, Barber_shifts>.AddEntity(barber_Shifts) == null)
                {
                    MessageBox.Show("Could not assign this shop and shift to the barber");
                }
                else
                {
                    Barber_Avail barberAvail = new Barber_Avail();
                    barberAvail.barber_id = Convert.ToInt32(barberId);
                    barberAvail.shift_id = Convert.ToInt32(shiftId);
                    barberAvail.shop_id = Convert.ToInt32(shopId);
                    //barberAvail.Barber_shifts = Controller<BarberShopEntities, Barber_shifts>.GetEntitiesWithIncluded("Barber", "Shift").Where(it => it.barber_id == Convert.ToInt32(barberId) && it.shift_id == Convert.ToInt32(shiftId)).FirstOrDefault();
                    //barberAvail.Shop = Controller<BarberShopEntities, Shop>.GetEntities(it => it.shop_id == Convert.ToInt32(shopId)).FirstOrDefault();
                    if (Controller<BarberShopEntities, Barber_Avail>.AddEntity(barberAvail) == null)
                    {
                        MessageBox.Show("Could not assign this shop and shift to the barber");
                    }
                    else
                    {
                        MessageBox.Show("Successfully assigned this shop and shift to the barber");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select valid barber, shop and shift");
            }
            InitializeDataGridView<Barber_shifts>(dataGridViewBarberShift, "Barber_shifts", "Barber_Avail", "Barber", "Shift");
            LoadBarberShopAvailability();
        }

        /// <summary>
        /// Called when restore button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            AddDataTableToDataSet("Barber", barberShopDataSet);
            AddDataTableToDataSet("Shops", barberShopDataSet);
            AddDataTableToDataSet("Barber_shifts", barberShopDataSet);
            AddDataTableToDataSet("Barber_Avail", barberShopDataSet);
            AddDataTableToDataSet("Appointment", barberShopDataSet);
            barberShopDataSet.AcceptChanges();
            barberShopDB.RestoreDataSetFromBackup(barberShopDataSet);
            BarberShopAdminForm_Load();
            MessageBox.Show("Data Restore Successful");
        }


        /// <summary>
        /// Called when backup button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBackup_Click(object sender, EventArgs e)
        {
            AddDataTableToDataSet("Barber", barberShopDataSet);
            AddDataTableToDataSet("Shops", barberShopDataSet);
            AddDataTableToDataSet("Barber_shifts", barberShopDataSet);
            AddDataTableToDataSet("Barber_Avail", barberShopDataSet);
            AddDataTableToDataSet("Appointment", barberShopDataSet);
            barberShopDataSet.AcceptChanges();
            barberShopDB.BackupDataSetToXML(barberShopDataSet);
            MessageBox.Show("Data Backup Successful");
        }


        /// <summary>
        /// Adds datatables of dataggridView to Dataset
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dataSet"></param>
        private void AddDataTableToDataSet(String tableName,DataSet dataSet)
        {
            if (dataSet.Tables.Contains(tableName))
                dataSet.Tables.Remove(tableName);
            DataTable table = barberShopDB.GetDataTable(tableName);
            dataSet.Tables.Add(table);
        }


        /// <summary>
        /// Calls to all Gridview initaialization called on form load
        /// </summary>
        private void BarberShopAdminForm_Load()
        {
            InitializeDataGridView<Shift>(dataGridViewShifts, "Shifts", "Barber_shifts");
            InitializeDataGridView<Barber>(dataGridViewBarber, "Barber", "Barber_shifts");
            InitializeDataGridView<Shop>(dataGridViewShop, "Shops", "Barber_Avail");
            InitializeDataGridView<Barber_shifts>(dataGridViewBarberShift, "Barber_shifts", "Barber_Avail", "Barber", "Shift");
            LoadBarberShopAvailability();
            LoadAppointments();
            
        }

        /// <summary>
        /// Populates the comboboxes
        /// </summary>
        private void PopulateComboBoxStatus()
        {
            var listStatus = Controller<BarberShopEntities, Status>.SetBindingList()
                             .Select(x => x.status_id);
            foreach(var item in listStatus) { 
                comboBoxStatus.Items.Add(item);
                comboBoxNewStatus.Items.Add(item);
            }

        }

        /// <summary>
        /// Initializes the gridview and populates the data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="tableName"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeDataGridView<T>(DataGridView gridView, string tableName, params string[] columnsToHide) where T : class
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

        /// <summary>
        /// populates dataGridViewBarberShiftAvail
        /// </summary>
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

        /// <summary>
        /// Populates the dataGridViewAppointments with appointments
        /// </summary>
        /// <param name="statusType"></param>
        private void LoadAppointments(String statusType="ALL")
        {
            var barberShopAvailability = Controller<BarberShopEntities, Barber_Avail>.GetEntitiesWithIncluded("Barber_shifts");
            var listBaberAssignment = barberShopAvailability.ToDictionary(x => x.barberAvail_id, x => x.Barber_shifts.price).ToList();

            var appointments = Controller<BarberShopEntities, Appointment>.GetEntitiesWithIncluded("Haircut", "Status", "User", "Barber_Avail");
            var listAppointments = (
                                      from appointment in appointments
                                      select new
                                      {
                                          
                                          id = appointment.appointment_id,
                                          barber_id = appointment.Barber_Avail.barber_id,
                                          //barber_name= appointment.Barber_Avail.Barber_shifts.Barber.barber_name,
                                          shift_id = appointment.Barber_Avail.shift_id,
                                          haircut = appointment.Haircut.description,
                                          user_id = appointment.User.user_id,
                                          user_name = appointment.User.user_name,
                                          cost =  appointment.Haircut.price,
                                          time = appointment.appointment_time,
                                          payment_status = appointment.payment_status,
                                          review = appointment.review,
                                          status = appointment.status_id
                                      })
                                      .Where(X=> statusType=="ALL" || X.status == statusType).ToList();
            InnitDatagridviewProperties(dataGridViewAppointments);
            dataGridViewAppointments.DataSource = listAppointments;
            dataGridViewAppointments.Columns["Haircut"].Visible = false;
            dataGridViewAppointments.Columns["review"].Visible = false;
            //dataGridViewAppointments.Columns["Status"].Visible = false;
            //dataGridViewAppointments.Columns["User"].Visible = false;
            //dataGridViewAppointments.Columns["Barber_Avail"].Visible = false;
        }


        /// <summary>
        /// Iniates Gridview with custom properyies suchas readonly, AllowUserToAddRows tec
        /// </summary>
        /// <param name="gridView"></param>
        private void InnitDatagridviewProperties(DataGridView gridView)
        {
            gridView.AllowUserToAddRows = false;

            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.MultiSelect = false;
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
        
    }
}
