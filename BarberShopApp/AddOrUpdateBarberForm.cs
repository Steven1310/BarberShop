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
    public partial class AddOrUpdateBarberForm : Form
    {
        /// <summary>
        ///  author: Steven 
        ///  id:300329089
        ///  Thus is the child form to add or upadte barber
        /// </summary>
        public AddOrUpdateBarberForm()
        {
            InitializeComponent();


            // register the event handlers
            this.Load += AddOrUpdateBarberForm_Load;
            buttonAddBarber.Click += ButtonAdd_Click;
            buttonUpdateBarber.Click += ButtonUpdate_Click;

            // register event handler for when a user is selected

            dataGridViewBarber.Click += (s, e) => GetSelectedBarber();
        }
        /// <summary>
        /// add the barber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxBarberName.Text))
            {
                MessageBox.Show("Enter Barber Name");
                return;
            }

            if (String.IsNullOrEmpty(textBoxBarberEmail.Text))
            {
                MessageBox.Show("Enter Barber Email");
                return;
            }

            if (String.IsNullOrEmpty(textBoxBarberContact.Text))
            {
                MessageBox.Show("Enter Barber Contact");
                return;
            }

            // get the barber data from the textboxes
            Barber barber = new Barber();


            barber.barber_name = textBoxBarberName.Text.Trim();
            barber.barber_email = textBoxBarberEmail.Text.Trim();
            barber.barber_contact = textBoxBarberContact.Text.Trim();


            if (barber.BarberInfoIsInvalid())
            {
                MessageBox.Show("Enter proper Barber details");
                return;
            }

            // now update the db
            if (Controller<BarberShopEntities, Barber>.AddEntity(barber) == null)
            {
                MessageBox.Show("Barber add to database failed");
                return;
            }

            // user.Appointments = department;

            if (Controller<BarberShopEntities, Barber>.UpdateEntity(barber) == false)
            {
                Controller<BarberShopEntities, Barber>.DeleteEntity(barber);
                MessageBox.Show("barber add to database failed");
                return;
            }

            else
            {
                MessageBox.Show("barber added successfully");
            }

            // if everyting is ok, close the form.

            this.DialogResult = DialogResult.OK;

            Close(); // this will not dispose the form on hide!


        }
        /// <summary>
        /// update the barber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewBarber.CurrentRow.DataBoundItem is Barber barber))
            {
                MessageBox.Show("You must Select Barber");
                return;
            }

            if (String.IsNullOrEmpty(textBoxBarberName.Text))
            {
                MessageBox.Show("Enter Barber Name");
                return;
            }

            if (String.IsNullOrEmpty(textBoxBarberEmail.Text))
            {
                MessageBox.Show("Enter Barber Email");
                return;
            }

            if (String.IsNullOrEmpty(textBoxBarberContact.Text))
            {
                MessageBox.Show("Enter Barber Contact");
                return;
            }

            // get the barber data from the textboxes

            barber.barber_name = textBoxBarberName.Text.Trim();
            barber.barber_email = textBoxBarberEmail.Text.Trim();
            barber.barber_contact = textBoxBarberContact.Text.Trim();

            if (barber.BarberInfoIsInvalid())
            {
                MessageBox.Show("Enter proper Barber details");
                return;
            }

            // now update the db
            if (Controller<BarberShopEntities, Barber>.UpdateEntity(barber) == false)
            {
                MessageBox.Show("Barber update to database failed");
                return;
            }
            else
            {
                MessageBox.Show("Barber updated successfully");
            }

            // if everyting is ok, close the form.

            this.DialogResult = DialogResult.OK;

            Close(); // this will not dispose the form on hide!

        }
        /// <summary>
        /// get the selected barber
        /// </summary>
        private void GetSelectedBarber()
        {
            if (!(dataGridViewBarber.CurrentRow.DataBoundItem is Barber barber))
                return;
            //updating the textbox according to listbox selection
            textBoxBarberName.Text = barber.barber_name.Trim();
            textBoxBarberEmail.Text = barber.barber_email.Trim();
            textBoxBarberContact.Text = barber.barber_contact.Trim();

        }


        /// <summary>
        /// initiazile form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateBarberForm_Load(object sender, EventArgs e)
        {
            dataGridViewBarber.AllowUserToAddRows = false;
            dataGridViewBarber.AllowUserToDeleteRows = false;
            dataGridViewBarber.ReadOnly = true;
            dataGridViewBarber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewBarber.DataSource = Controller<BarberShopEntities, Barber>.SetBindingList();
            dataGridViewBarber.Columns["Barber_shifts"].Visible = false;

            // set all textboxes to blank

            textBoxBarberName.ResetText();
            textBoxBarberEmail.ResetText();
            textBoxBarberContact.ResetText();
        }

    }
}
