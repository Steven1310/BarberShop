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
        private int userId;
        private int shopId;
        private int haircutId;
        private int barberAvailId;

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

        private void updatedBarberAvailData(object sender, EventArgs e)
        {
            barberAvailId = (int)dataGridViewBarber.CurrentRow.Cells["barberAvail_id"].Value;
        }

        private void updatedHaircutData(object sender, EventArgs e)
        {
            haircutId = (int)dataGridViewHaircut.CurrentRow.Cells["haircut_id"].Value;
        }

        private void updatedUserData(object sender, EventArgs e)
        {
             userId = (int)dataGridViewUser.CurrentRow.Cells["user_id"].Value;
        }

        private void bookAppointment(object sender, EventArgs e)
        {

            //if (String.IsNullOrEmpty(textBoxUserName.Text))
            //{
            //    MessageBox.Show("Enter User Name");
            //    return;
            //}

            //if (String.IsNullOrEmpty(textBoxUserEmail.Text))
            //{
            //    MessageBox.Show("Enter User Email");
            //    return;
            //}

            //if (String.IsNullOrEmpty(textBoxUserContact.Text))
            //{
            //    MessageBox.Show("Enter User Contact");
            //    return;
            //}
            //   INSERT INTO[dbo].[Appointment] ([appointment_id],[barberAvail_id],[haircut_id],[user_id],[appointment_time],[status_id],[payment_status]) VALUES(1, 1, 1, 1, '14:00:00', 'PENDING', 'N')

            // get the user data from the textboxes
            Appointment appointment = new Appointment();
            appointment.user_id = userId;
            appointment.barberAvail_id = barberAvailId;
            appointment.haircut_id = haircutId;
            appointment.status_id = "PENDING";
            TimeSpan appointmentTime =TimeSpan.Parse(textBoxAppointmentTime.Text);
            appointment.appointment_time = appointmentTime;

            if (checkBoxPaymentStatus.Checked)
            {
                appointment.payment_status = "Y";
            }
            

            //if (user.UserInfoIsInvalid())
            //{
            //    MessageBox.Show("Enter proper User details");
            //    return;
            //}

            // now update the db
            if (Controller<BarberShopEntities, Appointment>.AddEntity(appointment) == null)
            {
                MessageBox.Show("Appointment add to database failed");
                return;
            }

            // user.Appointments = department;

            //if (Controller<BarberShopEntities, User>.UpdateEntity(user) == false)
            //{
            //    Controller<BarberShopEntities, User>.DeleteEntity(user);
            //    MessageBox.Show("user add to database failed");
            //    return;
            //}

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

        private void updatedShopData(object sender=null, EventArgs e=null)
        {
             shopId = (int)dataGridViewShop.CurrentRow.Cells["shop_id"].Value;

            var query = Controller<BarberShopEntities, Barber_Avail>.GetEntities(it => it.shop_id == Convert.ToInt32(shopId));
            var barbers = Controller<BarberShopEntities, Shop>.GetEntitiesWithIncluded("Barber_Avail");
            
            dataGridViewBarber.DataSource = query.ToList();

        }

        private void AddAppointmentMainForm_Load()
        {
            InitializeDataGridView<User>(dataGridViewUser,"user_id", "user_email", "user_contact", "Appointments");
            InitializeDataGridView<Shop>(dataGridViewShop, "shop_id", "Barber_Avail");
            InitializeDataGridView<Barber_Avail>(dataGridViewBarber);
            InitializeDataGridView<Haircut>(dataGridViewHaircut,"picture","haircut_id","Appointments");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            //InnitDatagridviewProperties(gridView);


            gridView.DataSource = Controller<BarberShopEntities, T>.SetBindingList();


            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
        }

    }
}
