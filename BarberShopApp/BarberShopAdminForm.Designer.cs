namespace BarberShopApp
{
    partial class BarberShopAdminForm
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
            this.buttonAddUpdateBarber = new System.Windows.Forms.Button();
            this.buttonAddUpdateShifts = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.buttonAddUpdateShop = new System.Windows.Forms.Button();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.labelAppointments = new System.Windows.Forms.Label();
            this.labelBarber = new System.Windows.Forms.Label();
            this.labelShop = new System.Windows.Forms.Label();
            this.dataGridViewBarber = new System.Windows.Forms.DataGridView();
            this.dataGridViewShop = new System.Windows.Forms.DataGridView();
            this.labelShifts = new System.Windows.Forms.Label();
            this.dataGridViewShifts = new System.Windows.Forms.DataGridView();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.dataGridViewBarberShiftAvail = new System.Windows.Forms.DataGridView();
            this.labelBarberShiftAvailability = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarberShiftAvail)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddUpdateBarber
            // 
            this.buttonAddUpdateBarber.Location = new System.Drawing.Point(802, 84);
            this.buttonAddUpdateBarber.Name = "buttonAddUpdateBarber";
            this.buttonAddUpdateBarber.Size = new System.Drawing.Size(85, 62);
            this.buttonAddUpdateBarber.TabIndex = 27;
            this.buttonAddUpdateBarber.Text = "Add Or Update Barber";
            this.buttonAddUpdateBarber.UseVisualStyleBackColor = true;
            // 
            // buttonAddUpdateShifts
            // 
            this.buttonAddUpdateShifts.Location = new System.Drawing.Point(364, 278);
            this.buttonAddUpdateShifts.Name = "buttonAddUpdateShifts";
            this.buttonAddUpdateShifts.Size = new System.Drawing.Size(85, 62);
            this.buttonAddUpdateShifts.TabIndex = 26;
            this.buttonAddUpdateShifts.Text = "Add Or Update Shifts";
            this.buttonAddUpdateShifts.UseVisualStyleBackColor = true;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(875, 459);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(88, 33);
            this.buttonBackup.TabIndex = 25;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Location = new System.Drawing.Point(739, 456);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(90, 36);
            this.buttonChangeStatus.TabIndex = 24;
            this.buttonChangeStatus.Text = "Change Status";
            this.buttonChangeStatus.UseVisualStyleBackColor = true;
            // 
            // buttonAddUpdateShop
            // 
            this.buttonAddUpdateShop.Location = new System.Drawing.Point(364, 84);
            this.buttonAddUpdateShop.Name = "buttonAddUpdateShop";
            this.buttonAddUpdateShop.Size = new System.Drawing.Size(85, 62);
            this.buttonAddUpdateShop.TabIndex = 23;
            this.buttonAddUpdateShop.Text = "Add Or Update Shops";
            this.buttonAddUpdateShop.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(21, 436);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(714, 150);
            this.dataGridViewAppointments.TabIndex = 21;
            // 
            // labelAppointments
            // 
            this.labelAppointments.AutoSize = true;
            this.labelAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointments.Location = new System.Drawing.Point(18, 410);
            this.labelAppointments.Name = "labelAppointments";
            this.labelAppointments.Size = new System.Drawing.Size(83, 13);
            this.labelAppointments.TabIndex = 18;
            this.labelAppointments.Text = "Appointments";
            // 
            // labelBarber
            // 
            this.labelBarber.AutoSize = true;
            this.labelBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarber.Location = new System.Drawing.Point(470, 15);
            this.labelBarber.Name = "labelBarber";
            this.labelBarber.Size = new System.Drawing.Size(44, 13);
            this.labelBarber.TabIndex = 32;
            this.labelBarber.Text = "Barber";
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShop.Location = new System.Drawing.Point(18, 15);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(36, 13);
            this.labelShop.TabIndex = 31;
            this.labelShop.Text = "Shop";
            // 
            // dataGridViewBarber
            // 
            this.dataGridViewBarber.AllowUserToAddRows = false;
            this.dataGridViewBarber.AllowUserToDeleteRows = false;
            this.dataGridViewBarber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarber.Location = new System.Drawing.Point(473, 46);
            this.dataGridViewBarber.Name = "dataGridViewBarber";
            this.dataGridViewBarber.ReadOnly = true;
            this.dataGridViewBarber.Size = new System.Drawing.Size(323, 150);
            this.dataGridViewBarber.TabIndex = 30;
            // 
            // dataGridViewShop
            // 
            this.dataGridViewShop.AllowUserToAddRows = false;
            this.dataGridViewShop.AllowUserToDeleteRows = false;
            this.dataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShop.Location = new System.Drawing.Point(21, 46);
            this.dataGridViewShop.Name = "dataGridViewShop";
            this.dataGridViewShop.ReadOnly = true;
            this.dataGridViewShop.Size = new System.Drawing.Size(337, 150);
            this.dataGridViewShop.TabIndex = 29;
            // 
            // labelShifts
            // 
            this.labelShifts.AutoSize = true;
            this.labelShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShifts.Location = new System.Drawing.Point(18, 217);
            this.labelShifts.Name = "labelShifts";
            this.labelShifts.Size = new System.Drawing.Size(39, 13);
            this.labelShifts.TabIndex = 17;
            this.labelShifts.Text = "Shifts";
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(21, 242);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.Size = new System.Drawing.Size(337, 150);
            this.dataGridViewShifts.TabIndex = 20;
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(907, 278);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(85, 62);
            this.buttonAssign.TabIndex = 36;
            this.buttonAssign.Text = "Assign Barber Shop and Shift";
            this.buttonAssign.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBarberShiftAvail
            // 
            this.dataGridViewBarberShiftAvail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarberShiftAvail.Location = new System.Drawing.Point(473, 242);
            this.dataGridViewBarberShiftAvail.Name = "dataGridViewBarberShiftAvail";
            this.dataGridViewBarberShiftAvail.Size = new System.Drawing.Size(428, 150);
            this.dataGridViewBarberShiftAvail.TabIndex = 35;
            // 
            // labelBarberShiftAvailability
            // 
            this.labelBarberShiftAvailability.AutoSize = true;
            this.labelBarberShiftAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarberShiftAvailability.Location = new System.Drawing.Point(470, 217);
            this.labelBarberShiftAvailability.Name = "labelBarberShiftAvailability";
            this.labelBarberShiftAvailability.Size = new System.Drawing.Size(145, 13);
            this.labelBarberShiftAvailability.TabIndex = 33;
            this.labelBarberShiftAvailability.Text = "Barber Shifts Availability";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(547, 414);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(32, 13);
            this.labelFilter.TabIndex = 38;
            this.labelFilter.Text = "Filter:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(585, 411);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(150, 21);
            this.comboBoxStatus.TabIndex = 39;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(875, 512);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(88, 33);
            this.buttonRestore.TabIndex = 40;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            // 
            // BarberShopAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 601);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.dataGridViewBarberShiftAvail);
            this.Controls.Add(this.labelBarberShiftAvailability);
            this.Controls.Add(this.labelBarber);
            this.Controls.Add(this.labelShop);
            this.Controls.Add(this.dataGridViewBarber);
            this.Controls.Add(this.dataGridViewShop);
            this.Controls.Add(this.buttonAddUpdateBarber);
            this.Controls.Add(this.buttonAddUpdateShifts);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.buttonAddUpdateShop);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.dataGridViewShifts);
            this.Controls.Add(this.labelAppointments);
            this.Controls.Add(this.labelShifts);
            this.Name = "BarberShopAdminForm";
            this.Text = "BarberShopAdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarberShiftAvail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddUpdateBarber;
        private System.Windows.Forms.Button buttonAddUpdateShifts;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.Button buttonAddUpdateShop;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Label labelAppointments;
        private System.Windows.Forms.Label labelBarber;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.DataGridView dataGridViewBarber;
        private System.Windows.Forms.DataGridView dataGridViewShop;
        private System.Windows.Forms.Label labelShifts;
        private System.Windows.Forms.DataGridView dataGridViewShifts;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.DataGridView dataGridViewBarberShiftAvail;
        private System.Windows.Forms.Label labelBarberShiftAvailability;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonRestore;
    }
}