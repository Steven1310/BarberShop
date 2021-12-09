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
            this.comboBoxNewStatus = new System.Windows.Forms.ComboBox();
            this.labelNewStatus = new System.Windows.Forms.Label();
            this.dataGridViewBarberShift = new System.Windows.Forms.DataGridView();
            this.labelBarberShift = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarberShiftAvail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarberShift)).BeginInit();
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
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(708, 396);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(88, 33);
            this.buttonBackup.TabIndex = 25;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Location = new System.Drawing.Point(741, 712);
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
            this.dataGridViewAppointments.Location = new System.Drawing.Point(21, 612);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(714, 150);
            this.dataGridViewAppointments.TabIndex = 21;
            // 
            // labelAppointments
            // 
            this.labelAppointments.AutoSize = true;
            this.labelAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointments.Location = new System.Drawing.Point(18, 582);
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
            this.dataGridViewBarber.Size = new System.Drawing.Size(323, 127);
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
            this.dataGridViewShop.Size = new System.Drawing.Size(337, 127);
            this.dataGridViewShop.TabIndex = 29;
            // 
            // labelShifts
            // 
            this.labelShifts.AutoSize = true;
            this.labelShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShifts.Location = new System.Drawing.Point(18, 195);
            this.labelShifts.Name = "labelShifts";
            this.labelShifts.Size = new System.Drawing.Size(39, 13);
            this.labelShifts.TabIndex = 17;
            this.labelShifts.Text = "Shifts";
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(21, 220);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.Size = new System.Drawing.Size(337, 130);
            this.dataGridViewShifts.TabIndex = 20;
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(502, 432);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(85, 62);
            this.buttonAssign.TabIndex = 36;
            this.buttonAssign.Text = "Assign Barber Shop and Shift";
            this.buttonAssign.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBarberShiftAvail
            // 
            this.dataGridViewBarberShiftAvail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarberShiftAvail.Location = new System.Drawing.Point(21, 396);
            this.dataGridViewBarberShiftAvail.Name = "dataGridViewBarberShiftAvail";
            this.dataGridViewBarberShiftAvail.Size = new System.Drawing.Size(428, 130);
            this.dataGridViewBarberShiftAvail.TabIndex = 35;
            // 
            // labelBarberShiftAvailability
            // 
            this.labelBarberShiftAvailability.AutoSize = true;
            this.labelBarberShiftAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarberShiftAvailability.Location = new System.Drawing.Point(18, 371);
            this.labelBarberShiftAvailability.Name = "labelBarberShiftAvailability";
            this.labelBarberShiftAvailability.Size = new System.Drawing.Size(145, 13);
            this.labelBarberShiftAvailability.TabIndex = 33;
            this.labelBarberShiftAvailability.Text = "Barber Shifts Availability";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(547, 585);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(32, 13);
            this.labelFilter.TabIndex = 38;
            this.labelFilter.Text = "Filter:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(585, 582);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(150, 21);
            this.comboBoxStatus.TabIndex = 39;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(708, 447);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(88, 33);
            this.buttonRestore.TabIndex = 40;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            // 
            // comboBoxNewStatus
            // 
            this.comboBoxNewStatus.FormattingEnabled = true;
            this.comboBoxNewStatus.Location = new System.Drawing.Point(741, 674);
            this.comboBoxNewStatus.Name = "comboBoxNewStatus";
            this.comboBoxNewStatus.Size = new System.Drawing.Size(109, 21);
            this.comboBoxNewStatus.TabIndex = 41;
            // 
            // labelNewStatus
            // 
            this.labelNewStatus.AutoSize = true;
            this.labelNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewStatus.Location = new System.Drawing.Point(738, 658);
            this.labelNewStatus.Name = "labelNewStatus";
            this.labelNewStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNewStatus.Size = new System.Drawing.Size(72, 13);
            this.labelNewStatus.TabIndex = 42;
            this.labelNewStatus.Text = "New Status";
            // 
            // dataGridViewBarberShift
            // 
            this.dataGridViewBarberShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarberShift.Location = new System.Drawing.Point(473, 220);
            this.dataGridViewBarberShift.Name = "dataGridViewBarberShift";
            this.dataGridViewBarberShift.Size = new System.Drawing.Size(337, 130);
            this.dataGridViewBarberShift.TabIndex = 44;
            // 
            // labelBarberShift
            // 
            this.labelBarberShift.AutoSize = true;
            this.labelBarberShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarberShift.Location = new System.Drawing.Point(470, 195);
            this.labelBarberShift.Name = "labelBarberShift";
            this.labelBarberShift.Size = new System.Drawing.Size(80, 13);
            this.labelBarberShift.TabIndex = 43;
            this.labelBarberShift.Text = "Barber Shifts";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(460, 406);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 45;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(502, 403);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 46;
            // 
            // BarberShopAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 774);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.dataGridViewBarberShift);
            this.Controls.Add(this.labelBarberShift);
            this.Controls.Add(this.labelNewStatus);
            this.Controls.Add(this.comboBoxNewStatus);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarberShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddUpdateBarber;
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
        private System.Windows.Forms.ComboBox comboBoxNewStatus;
        private System.Windows.Forms.Label labelNewStatus;
        private System.Windows.Forms.DataGridView dataGridViewBarberShift;
        private System.Windows.Forms.Label labelBarberShift;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}