using BaberViewModel;
using BarberShopCodeFirstFromDB;
using EFControllerUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShopApp
{
    public partial class BarberForm : Form
    {
        public BarberForm()
        {
            InitializeComponent();
            BarberForm_Load();


        }

        private void BarberForm_Load()
        {
            InitializeAppointmentDataGridView<Appointment>(dataGridViewAppointmentDetails, "Haircut", "Status", "User", "Barber_Avail");

            //  InitializeDataGridView<Appointment>(dataGridViewAppointmentDetails, "Haircut", "Status", "User", "Barber_Avail", "Review");
        }

        /// <summary>
        /// initialize datagridview generic method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeAppointmentDataGridView<T>(DataGridView gridView, params string[] includeParames) where T : Appointment
        {

            InnitDatagridviewProperties(gridView);
            // Allow users to add/delete rows, and fill out columns to the entire width of the control
            var results = Controller<BarberShopEntities, T>.SetObservableCollection(includeParames);
            var babers = Controller<BarberShopEntities, Barber>.SetBindingList();
            List<AppointmentViewModel> appointmentViews = new List<AppointmentViewModel>();
            if (results != null)
            {
                foreach (var item in results)
                {
                    AppointmentViewModel viewModel = new AppointmentViewModel();
                    viewModel.appointment_id = item.appointment_id;
                    viewModel.appointment_time = item.appointment_time.Value;
                    viewModel.BarberName = babers.SingleOrDefault(it => it.barber_id == item.Barber_Avail.barber_id).barber_name;
                    viewModel.HairStyle = item.Haircut.description;
                    viewModel.Status = item.Status.status_id;
                    viewModel.payment_status = item.payment_status;
                    viewModel.user_name = item.User.user_name;
                    appointmentViews.Add(viewModel);
                }
            }
            gridView.DataSource = appointmentViews;
        }

        private void InnitDatagridviewProperties(DataGridView gridView)
        {
            gridView.AllowUserToAddRows = false;

            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            UpdateStatus("ACCEPTED");

        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            UpdateStatus("REJECTED");
        }

        private void UpdateStatus(string status)
        {
            if (dataGridViewAppointmentDetails.SelectedRows.Count > 0)
            {
                var currentStaut = Convert.ToString(dataGridViewAppointmentDetails.CurrentRow.Cells["Status"].Value);
                if (currentStaut == "ACCEPTED" || currentStaut == "FULLFILLED")
                {
                    MessageBox.Show("Could not change the status");
                    return;
                }
                var appointmentId = Convert.ToInt32(dataGridViewAppointmentDetails.CurrentRow.Cells["appointment_id"].Value);
                var appointment = Controller<BarberShopEntities, Appointment>.FindEntity(appointmentId);
                if (appointment != null)
                {
                    appointment.status_id = status;
                }
                if (Controller<BarberShopEntities, Appointment>.UpdateEntity(appointment))
                {
                    MessageBox.Show("Update status successfully");
                    BarberForm_Load();
                }
                else
                {
                    MessageBox.Show("Update status failed");
                }
            }
            else
            {
                MessageBox.Show("Please select a record!");
            }
        }

        private void btnfullfilled_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointmentDetails.SelectedRows.Count > 0)
            {
                var currentStaut = Convert.ToString(dataGridViewAppointmentDetails.CurrentRow.Cells["Status"].Value);
                if (String.Compare(currentStaut.Trim(),"ACCEPTED") == 0)
                {
                    var appointmentId = Convert.ToInt32(dataGridViewAppointmentDetails.CurrentRow.Cells["appointment_id"].Value);
                    var appointment = Controller<BarberShopEntities, Appointment>.FindEntity(appointmentId);
                    if (appointment != null)
                    {
                        appointment.status_id = "FULLFILLED";
                        appointment.payment_status = "Y";
                    }
                    if (Controller<BarberShopEntities, Appointment>.UpdateEntity(appointment))
                    {
                        MessageBox.Show("Update status successfully");
                        BarberForm_Load();
                    }
                    else
                    {
                        MessageBox.Show("Update status failed");
                    }
                }
                else
                {
                    MessageBox.Show("Could not change the status");
                }
            }
            else
            {
                MessageBox.Show("Please select a record!");
            }
        }
    }
}
