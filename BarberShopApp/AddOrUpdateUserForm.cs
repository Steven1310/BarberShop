using BarberShopCodeFirstFromDB;
using BarberShopValidation;
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
    public partial class AddOrUpdateUserForm : Form
    {
        public AddOrUpdateUserForm()
        {
            InitializeComponent();


            // register the event handlers
            this.Load += AddOrUpdateUsersForm_Load;
            buttonAddUser.Click += ButtonAdd_Click;
            buttonUpdateUser.Click += ButtonUpdate_Click;

            // register event handler for when a user is selected

            dataGridViewUsers.Click += (s, e) => GetSelectedUser();
        }
        /// <summary>
        /// add the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Enter User Name");
                return;
            }

            if (String.IsNullOrEmpty(textBoxUserEmail.Text))
            {
                MessageBox.Show("Enter User Email");
                return;
            }

            if (String.IsNullOrEmpty(textBoxUserContact.Text))
            {
                MessageBox.Show("Enter User Contact");
                return;
            }

            // get the user data from the textboxes
            User user = new User();


            user.user_name = textBoxUserName.Text;
            user.user_email = textBoxUserEmail.Text;
            user.user_contact = textBoxUserContact.Text;


            if (user.UserInfoIsInvalid())
            {
                MessageBox.Show("Enter proper User details");
                return;
            }

            // now update the db
            if (Controller<BarberShopEntities, User>.AddEntity(user) == null)
            {
                MessageBox.Show("User add to database failed");
                return;
            }

            // user.Appointments = department;

            if (Controller<BarberShopEntities, User>.UpdateEntity(user) == false)
            {
                Controller<BarberShopEntities, User>.DeleteEntity(user);
                MessageBox.Show("user add to database failed");
                return;
            }

            else
            {
                MessageBox.Show("User added successfully");
            }

            // if everyting is ok, close the form.

            this.DialogResult = DialogResult.OK;

            Close(); // this will not dispose the form on hide!


        }
        /// <summary>
        /// update the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewUsers.CurrentRow.DataBoundItem is User user))
            {
                MessageBox.Show("You must Select User");
                return;
            }

            if (String.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Enter User Name");
                return;
            }

            if (String.IsNullOrEmpty(textBoxUserEmail.Text))
            {
                MessageBox.Show("Enter User Email");
                return;
            }

            if (String.IsNullOrEmpty(textBoxUserContact.Text))
            {
                MessageBox.Show("Enter User Contact");
                return;
            }

            // get the user data from the textboxes

            user.user_name = textBoxUserName.Text;
            user.user_email = textBoxUserEmail.Text;
            user.user_contact = textBoxUserContact.Text;

            if (user.UserInfoIsInvalid())
            {
                MessageBox.Show("Enter proper User details");
                return;
            }

            // now update the db
            if (Controller<BarberShopEntities, User>.UpdateEntity(user) == false)
            {
                MessageBox.Show("Course update to database failed");
                return;
            }
            else
            {
                MessageBox.Show("Course updated successfully");
            }

            // if everyting is ok, close the form.

            this.DialogResult = DialogResult.OK;

            Close(); // this will not dispose the form on hide!

        }
        /// <summary>
        /// get the selected user
        /// </summary>
        private void GetSelectedUser()
        {
            if (!(dataGridViewUsers.CurrentRow.DataBoundItem is User user))
                return;
            //updating the textbox according to listbox selection
            textBoxUserName.Text = user.user_name;
            textBoxUserEmail.Text = user.user_email;
            textBoxUserContact.Text = user.user_contact;

        }


        /// <summary>
        /// initiazile form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateUsersForm_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewUsers.DataSource = Controller<BarberShopEntities, User>.SetBindingList();
                dataGridViewUsers.Columns["Appointments"].Visible = false;

            // set all textboxes to blank

            textBoxUserName.ResetText();
            textBoxUserEmail.ResetText();
            textBoxUserContact.ResetText();
        }

    }
}
