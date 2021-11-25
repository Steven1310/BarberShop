using BarberShopCodeFirstFromDB;
using SeedDatabaseExtensions;
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
    /// <summary>
    ///  author: Steven 
    ///  id:300329089
    ///  Thus is the main form and has 3 buttons "USER", "BARBER" and "ADMIN"
    /// </summary>
    public partial class BarberShopAppForm : Form
    {
        public BarberShopAppForm()
        {
            InitializeComponent();
            this.Text = "Precise Cut";
            this.Load += (s, e) => BarberShopAppMainForm_Load();
        }

        private void BarberShopAppMainForm_Load()
        {
            using (BarberShopEntities context = new BarberShopEntities())
            {
                context.SeedDatabase();
            }
        }
    }
}
