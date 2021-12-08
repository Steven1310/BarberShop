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
    public partial class AddAppointment : Form
    {
        private int userId=-1;
        private int shopId=-1;
        private int haircutId=-1;
        private int barberAvailId=-1;
        private int totalPrice=-1;
        private int barberPrice;
        private int barberId=-1;

        public AddAppointment()
        {
            InitializeComponent();
            this.Load += (s, e) => AddAppointmentMainForm_Load();

            // register event handler for when a datagridview row is selected

            dataGridViewUser.Click += updatedUserData;
            dataGridViewShop.Click += updatedShopData;
            dataGridViewHaircut.Click += updatedHaircutData;
            dataGridViewBarber.Click += updatedBarberAvailData;


            buttonBookAppointment.Click += bookAppointment;

        }
        /// <summary>
        /// update the id clicked by the user from the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updatedBarberAvailData(object sender, EventArgs e)
        {
            barberAvailId = (int)dataGridViewBarber.CurrentRow.Cells["barberAvail_id"].Value;
            barberId = (int)dataGridViewBarber.CurrentRow.Cells["shift_id"].Value;
            barberPrice = Controller<BarberShopEntities, Barber_shifts>.GetEntities(it => it.shift_id == Convert.ToInt32(barberId)).Select(x=>x.price).SingleOrDefault();
          

        }
        /// <summary>
        ///  update the id clicked by the user from the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updatedHaircutData(object sender, EventArgs e)
        {
            haircutId = (int)dataGridViewHaircut.CurrentRow.Cells["haircut_id"].Value;
            totalPrice = (int)dataGridViewHaircut.CurrentRow.Cells["price"].Value + barberPrice;
            labelPrice.Text = "$" + totalPrice.ToString();

        }
        /// <summary>
        ///  update the id clicked by the user from the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updatedUserData(object sender, EventArgs e)
        {
            userId = (int)dataGridViewUser.CurrentRow.Cells["user_id"].Value;
        }
        /// <summary>
        ///  update the id clicked by the user from the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookAppointment(object sender, EventArgs e)
        {
            if (userId == -1 || barberAvailId == -1 || haircutId == -1 || textBoxAppointmentTime.Text=="")
            {
                MessageBox.Show("Data field needs to be selected or inserted");
            }
            else
            {
                // get the user data from the textboxes
                Appointment appointment = new Appointment();
                appointment.user_id = userId;
                appointment.barberAvail_id = barberAvailId;
                appointment.haircut_id = haircutId;
                appointment.status_id = "PENDING";
                TimeSpan appointmentTime = TimeSpan.Parse(textBoxAppointmentTime.Text);
                appointment.appointment_time = appointmentTime;
                if (checkBoxPaymentStatus.Checked)
                {
                    appointment.payment_status = "Y";
                }
                else
                    appointment.payment_status = "N";

                // now update the db
                if (Controller<BarberShopEntities, Appointment>.AddEntity(appointment) == null)
                {
                    MessageBox.Show("Appointment add to database failed");
                    return;
                }


                else
                {
                    MessageBox.Show("Appointment added successfully");
                    UserHomepage userHomepage = new UserHomepage();
                    userHomepage.Show();
                }

                // if everyting is ok, close the form.

                this.DialogResult = DialogResult.OK;

                Close(); // this will not dispose the form on hide!
            }

        }
        /// <summary>
        ///  update the id clicked by the user from the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updatedShopData(object sender = null, EventArgs e = null)
        {
            shopId = (int)dataGridViewShop.CurrentRow.Cells["shop_id"].Value;

            var queryGetData = Controller<BarberShopEntities, Barber_Avail>.GetEntities(it => it.shop_id == Convert.ToInt32(shopId));

            dataGridViewBarber.DataSource = queryGetData.ToList();

        }
        /// <summary>
        /// initialize the form
        /// </summary>
        private void AddAppointmentMainForm_Load()
        {
            InitializeDataGridView<User>(dataGridViewUser, "user_id", "user_email", "user_contact", "Appointments");
            InitializeDataGridView<Shop>(dataGridViewShop, "shop_id", "Barber_Avail");
            InitializeDataGridView<Barber_Avail>(dataGridViewBarber);
            InitializeDataGridView<Haircut>(dataGridViewHaircut, "picture", "haircut_id", "Appointments");

        }

        /// <summary>
        /// initialize datagridview generic method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            gridView.DataSource = Controller<BarberShopEntities, T>.SetBindingList();


            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
        }

    }
}
