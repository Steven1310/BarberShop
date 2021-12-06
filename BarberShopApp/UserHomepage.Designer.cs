
namespace BarberShopApp
{
    partial class UserHomepage
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
            this.labelUserTable = new System.Windows.Forms.Label();
            this.labelAppointmentsTable = new System.Windows.Forms.Label();
            this.dataGridViewAppointmentDetails = new System.Windows.Forms.DataGridView();
            this.buttonAddUpdateUser = new System.Windows.Forms.Button();
            this.dataGridViewUserDetails = new System.Windows.Forms.DataGridView();
            this.buttonAddNewAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserTable
            // 
            this.labelUserTable.AutoSize = true;
            this.labelUserTable.Location = new System.Drawing.Point(48, 22);
            this.labelUserTable.Name = "labelUserTable";
            this.labelUserTable.Size = new System.Drawing.Size(34, 13);
            this.labelUserTable.TabIndex = 0;
            this.labelUserTable.Text = "Users";
            // 
            // labelAppointmentsTable
            // 
            this.labelAppointmentsTable.AutoSize = true;
            this.labelAppointmentsTable.Location = new System.Drawing.Point(48, 230);
            this.labelAppointmentsTable.Name = "labelAppointmentsTable";
            this.labelAppointmentsTable.Size = new System.Drawing.Size(71, 13);
            this.labelAppointmentsTable.TabIndex = 1;
            this.labelAppointmentsTable.Text = "Appointments";
            // 
            // dataGridViewAppointmentDetails
            // 
            this.dataGridViewAppointmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentDetails.Location = new System.Drawing.Point(51, 255);
            this.dataGridViewAppointmentDetails.Name = "dataGridViewAppointmentDetails";
            this.dataGridViewAppointmentDetails.Size = new System.Drawing.Size(887, 208);
            this.dataGridViewAppointmentDetails.TabIndex = 3;
            // 
            // buttonAddUpdateUser
            // 
            this.buttonAddUpdateUser.Location = new System.Drawing.Point(668, 117);
            this.buttonAddUpdateUser.Name = "buttonAddUpdateUser";
            this.buttonAddUpdateUser.Size = new System.Drawing.Size(77, 43);
            this.buttonAddUpdateUser.TabIndex = 4;
            this.buttonAddUpdateUser.Text = "Add/Update User";
            this.buttonAddUpdateUser.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUserDetails
            // 
            this.dataGridViewUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserDetails.Location = new System.Drawing.Point(51, 51);
            this.dataGridViewUserDetails.Name = "dataGridViewUserDetails";
            this.dataGridViewUserDetails.Size = new System.Drawing.Size(598, 167);
            this.dataGridViewUserDetails.TabIndex = 6;
            // 
            // buttonAddNewAppointment
            // 
            this.buttonAddNewAppointment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAddNewAppointment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewAppointment.Location = new System.Drawing.Point(823, 104);
            this.buttonAddNewAppointment.Name = "buttonAddNewAppointment";
            this.buttonAddNewAppointment.Size = new System.Drawing.Size(106, 66);
            this.buttonAddNewAppointment.TabIndex = 7;
            this.buttonAddNewAppointment.Text = "Add New Appointment";
            this.buttonAddNewAppointment.UseVisualStyleBackColor = false;
            // 
            // UserHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 503);
            this.Controls.Add(this.buttonAddNewAppointment);
            this.Controls.Add(this.dataGridViewUserDetails);
            this.Controls.Add(this.buttonAddUpdateUser);
            this.Controls.Add(this.dataGridViewAppointmentDetails);
            this.Controls.Add(this.labelAppointmentsTable);
            this.Controls.Add(this.labelUserTable);
            this.Name = "UserHomepage";
            this.Text = "UserHomepage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserTable;
        private System.Windows.Forms.Label labelAppointmentsTable;
        private System.Windows.Forms.DataGridView dataGridViewAppointmentDetails;
        private System.Windows.Forms.Button buttonAddUpdateUser;
        private System.Windows.Forms.DataGridView dataGridViewUserDetails;
        private System.Windows.Forms.Button buttonAddNewAppointment;
    }
}