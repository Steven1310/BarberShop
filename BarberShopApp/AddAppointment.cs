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
        public AddAppointment()
        {
            InitializeComponent();
            this.Load += (s, e) => AddAppointmentMainForm_Load();

            // register event handler for when a datagridview row is selected

            dataGridViewShop.Click += updatedData;

        }

        private void updatedData(object sender=null, EventArgs e=null)
        {
            var shopId = dataGridViewShop.CurrentRow.Cells["shop_id"].Value;

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
