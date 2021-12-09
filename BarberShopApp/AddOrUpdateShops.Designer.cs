namespace BarberShopApp
{
    partial class AddOrUpdateShops
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewShops = new System.Windows.Forms.DataGridView();
            this.buttonUpdateShop = new System.Windows.Forms.Button();
            this.buttonAddShop = new System.Windows.Forms.Button();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxShopLocation = new System.Windows.Forms.TextBox();
            this.textBoxShopName = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelShops = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShops
            // 
            this.dataGridViewShops.AllowUserToAddRows = false;
            this.dataGridViewShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShops.Location = new System.Drawing.Point(67, 46);
            this.dataGridViewShops.Name = "dataGridViewShops";
            this.dataGridViewShops.ReadOnly = true;
            this.dataGridViewShops.Size = new System.Drawing.Size(489, 274);
            this.dataGridViewShops.TabIndex = 30;
            // 
            // buttonUpdateShop
            // 
            this.buttonUpdateShop.Location = new System.Drawing.Point(287, 540);
            this.buttonUpdateShop.Name = "buttonUpdateShop";
            this.buttonUpdateShop.Size = new System.Drawing.Size(95, 39);
            this.buttonUpdateShop.TabIndex = 29;
            this.buttonUpdateShop.Text = "Update Shop";
            this.buttonUpdateShop.UseVisualStyleBackColor = true;
            // 
            // buttonAddShop
            // 
            this.buttonAddShop.Location = new System.Drawing.Point(165, 540);
            this.buttonAddShop.Name = "buttonAddShop";
            this.buttonAddShop.Size = new System.Drawing.Size(80, 39);
            this.buttonAddShop.TabIndex = 28;
            this.buttonAddShop.Text = "Add Shop";
            this.buttonAddShop.UseVisualStyleBackColor = true;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(198, 473);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(169, 20);
            this.textBoxPostalCode.TabIndex = 27;
            // 
            // textBoxShopLocation
            // 
            this.textBoxShopLocation.Location = new System.Drawing.Point(198, 404);
            this.textBoxShopLocation.Name = "textBoxShopLocation";
            this.textBoxShopLocation.Size = new System.Drawing.Size(169, 20);
            this.textBoxShopLocation.TabIndex = 26;
            // 
            // textBoxShopName
            // 
            this.textBoxShopName.Location = new System.Drawing.Point(198, 335);
            this.textBoxShopName.Name = "textBoxShopName";
            this.textBoxShopName.Size = new System.Drawing.Size(169, 20);
            this.textBoxShopName.TabIndex = 25;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(111, 480);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(61, 13);
            this.labelPostalCode.TabIndex = 24;
            this.labelPostalCode.Text = "PostalCode";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(111, 407);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 23;
            this.labelLocation.Text = "Location";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(111, 335);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Name";
            // 
            // labelShops
            // 
            this.labelShops.AutoSize = true;
            this.labelShops.Location = new System.Drawing.Point(64, 18);
            this.labelShops.Name = "labelShops";
            this.labelShops.Size = new System.Drawing.Size(37, 13);
            this.labelShops.TabIndex = 21;
            this.labelShops.Text = "Shops";
            // 
            // AddOrUpdateShops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 620);
            this.Controls.Add(this.dataGridViewShops);
            this.Controls.Add(this.buttonUpdateShop);
            this.Controls.Add(this.buttonAddShop);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxShopLocation);
            this.Controls.Add(this.textBoxShopName);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelShops);
            this.Name = "AddOrUpdateShops";
            this.Text = "AddOrUpdateShops";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShops;
        private System.Windows.Forms.Button buttonUpdateShop;
        private System.Windows.Forms.Button buttonAddShop;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxShopLocation;
        private System.Windows.Forms.TextBox textBoxShopName;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelShops;
    }
}