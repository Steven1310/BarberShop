namespace BarberShopApp
{
    partial class AddOrUpdateBarberForm
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
            this.dataGridViewBarber = new System.Windows.Forms.DataGridView();
            this.buttonUpdateBarber = new System.Windows.Forms.Button();
            this.buttonAddBarber = new System.Windows.Forms.Button();
            this.textBoxBarberContact = new System.Windows.Forms.TextBox();
            this.textBoxBarberEmail = new System.Windows.Forms.TextBox();
            this.textBoxBarberName = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBarber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBarber
            // 
            this.dataGridViewBarber.AllowUserToAddRows = false;
            this.dataGridViewBarber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarber.Location = new System.Drawing.Point(89, 49);
            this.dataGridViewBarber.Name = "dataGridViewBarber";
            this.dataGridViewBarber.ReadOnly = true;
            this.dataGridViewBarber.Size = new System.Drawing.Size(489, 274);
            this.dataGridViewBarber.TabIndex = 20;
            // 
            // buttonUpdateBarber
            // 
            this.buttonUpdateBarber.Location = new System.Drawing.Point(309, 543);
            this.buttonUpdateBarber.Name = "buttonUpdateBarber";
            this.buttonUpdateBarber.Size = new System.Drawing.Size(95, 39);
            this.buttonUpdateBarber.TabIndex = 19;
            this.buttonUpdateBarber.Text = "Update Barber";
            this.buttonUpdateBarber.UseVisualStyleBackColor = true;
            // 
            // buttonAddBarber
            // 
            this.buttonAddBarber.Location = new System.Drawing.Point(187, 543);
            this.buttonAddBarber.Name = "buttonAddBarber";
            this.buttonAddBarber.Size = new System.Drawing.Size(80, 39);
            this.buttonAddBarber.TabIndex = 18;
            this.buttonAddBarber.Text = "Add Barber";
            this.buttonAddBarber.UseVisualStyleBackColor = true;
            // 
            // textBoxBarberContact
            // 
            this.textBoxBarberContact.Location = new System.Drawing.Point(220, 476);
            this.textBoxBarberContact.Name = "textBoxBarberContact";
            this.textBoxBarberContact.Size = new System.Drawing.Size(169, 20);
            this.textBoxBarberContact.TabIndex = 17;
            // 
            // textBoxBarberEmail
            // 
            this.textBoxBarberEmail.Location = new System.Drawing.Point(220, 407);
            this.textBoxBarberEmail.Name = "textBoxBarberEmail";
            this.textBoxBarberEmail.Size = new System.Drawing.Size(169, 20);
            this.textBoxBarberEmail.TabIndex = 16;
            // 
            // textBoxBarberName
            // 
            this.textBoxBarberName.Location = new System.Drawing.Point(220, 338);
            this.textBoxBarberName.Name = "textBoxBarberName";
            this.textBoxBarberName.Size = new System.Drawing.Size(169, 20);
            this.textBoxBarberName.TabIndex = 15;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(133, 483);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(44, 13);
            this.labelContact.TabIndex = 14;
            this.labelContact.Text = "Contact";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(133, 410);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(133, 338);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // labelBarber
            // 
            this.labelBarber.AutoSize = true;
            this.labelBarber.Location = new System.Drawing.Point(86, 21);
            this.labelBarber.Name = "labelBarber";
            this.labelBarber.Size = new System.Drawing.Size(43, 13);
            this.labelBarber.TabIndex = 11;
            this.labelBarber.Text = "Barbers";
            // 
            // AddOrUpdateBarberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 616);
            this.Controls.Add(this.dataGridViewBarber);
            this.Controls.Add(this.buttonUpdateBarber);
            this.Controls.Add(this.buttonAddBarber);
            this.Controls.Add(this.textBoxBarberContact);
            this.Controls.Add(this.textBoxBarberEmail);
            this.Controls.Add(this.textBoxBarberName);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelBarber);
            this.Name = "AddOrUpdateBarberForm";
            this.Text = "AddOrUpdateBarberForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBarber;
        private System.Windows.Forms.Button buttonUpdateBarber;
        private System.Windows.Forms.Button buttonAddBarber;
        private System.Windows.Forms.TextBox textBoxBarberContact;
        private System.Windows.Forms.TextBox textBoxBarberEmail;
        private System.Windows.Forms.TextBox textBoxBarberName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBarber;
    }
}