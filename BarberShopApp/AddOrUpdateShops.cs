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
    public partial class AddOrUpdateShops : Form
    {
        /// <summary>
        ///  author: Steven 
        ///  id:300329089
        ///  Thus is the Admin form and has all the admin controls
        /// </summary>
        public AddOrUpdateShops()
        {
            InitializeComponent();
            // register the event handlers
            this.Load += AddOrUpdateShopForm_Load;
            buttonAddShop.Click += ButtonAdd_Click;
            buttonUpdateShop.Click += ButtonUpdate_Click;

            // register event handler for when a user is selected

            dataGridViewShops.Click += (s, e) => GetSelectedShop();
        }
        /// <summary>
        /// add the shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxShopName.Text))
            {
                MessageBox.Show("Enter Shop Name");
                return;
            }

            if (String.IsNullOrEmpty(textBoxShopLocation.Text))
            {
                MessageBox.Show("Enter Shop Location");
                return;
            }

            if (String.IsNullOrEmpty(textBoxPostalCode.Text))
            {
                MessageBox.Show("Enter Shop Postal code");
                return;
            }

            // get the shop data from the textboxes
            Shop shop = new Shop();


            shop.shop_name = textBoxShopName.Text.Trim();
            shop.location = textBoxShopLocation.Text.Trim();
            shop.postal_code = textBoxPostalCode.Text.Trim();


            if (shop.ShopInfoIsInvalid())
            {
                MessageBox.Show("Enter proper Shop details");
                return;
            }

            // now update the db
            if (Controller<BarberShopEntities, Shop>.AddEntity(shop) == null)
            {
                MessageBox.Show("Shop add to database failed");
                return;
            }

            // user.Appointments = department;

            if (Controller<BarberShopEntities, Shop>.UpdateEntity(shop) == false)
            {
                Controller<BarberShopEntities, Shop>.DeleteEntity(shop);
                MessageBox.Show("Shop add to database failed");
                return;
            }

            else
            {
                MessageBox.Show("shop added successfully");
            }

            // if everyting is ok, close the form.

            this.DialogResult = DialogResult.OK;

            Close(); // this will not dispose the form on hide!


        }
        /// <summary>
        /// update the shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewShops.CurrentRow.DataBoundItem is Shop shop))
            {
                MessageBox.Show("You must Select Shop");
                return;
            }

            if (String.IsNullOrEmpty(textBoxShopName.Text))
            {
                MessageBox.Show("Enter Shop Name");
                return;
            }

            if (String.IsNullOrEmpty(textBoxShopLocation.Text))
            {
                MessageBox.Show("Enter Shop Location");
                return;
            }

            if (String.IsNullOrEmpty(textBoxPostalCode.Text))
            {
                MessageBox.Show("Enter Shop Postal code");
                return;
            }

            // get the user data from the textboxes

            shop.shop_name = textBoxShopName.Text.Trim();
            shop.location = textBoxShopLocation.Text.Trim();
            shop.postal_code = textBoxPostalCode.Text.Trim();

            if (shop.ShopInfoIsInvalid())
            {
                MessageBox.Show("Enter proper Shop details");
                return;
            }

            // now update the db
            if (Controller<BarberShopEntities, Shop>.UpdateEntity(shop) == false)
            {
                MessageBox.Show("shop update to database failed");
                return;
            }
            else
            {
                MessageBox.Show("shop updated successfully");
            }

            // if everyting is ok, close the form.

            this.DialogResult = DialogResult.OK;

            Close(); // this will not dispose the form on hide!

        }
        /// <summary>
        /// get the selected shop
        /// </summary>
        private void GetSelectedShop()
        {
            if (!(dataGridViewShops.CurrentRow.DataBoundItem is Shop shop))
                return;
            //updating the textbox according to listbox selection
            textBoxShopName.Text = shop.shop_name.Trim();
            textBoxShopLocation.Text = shop.location.Trim();
            textBoxPostalCode.Text = shop.postal_code.Trim();

        }


        /// <summary>
        /// initiazile form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateShopForm_Load(object sender, EventArgs e)
        {
            dataGridViewShops.AllowUserToAddRows = false;
            dataGridViewShops.AllowUserToDeleteRows = false;
            dataGridViewShops.ReadOnly = true;
            dataGridViewShops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewShops.DataSource = Controller<BarberShopEntities, Shop>.SetBindingList();
            dataGridViewShops.Columns["Barber_Avail"].Visible = false;

            // set all textboxes to blank

            textBoxShopName.ResetText();
            textBoxShopLocation.ResetText();
            textBoxPostalCode.ResetText();
        }

    }
}

