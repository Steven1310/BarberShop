
namespace BarberShopApp
{
    partial class BarberForm
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.dropButton = new System.Windows.Forms.Button();
            this.dataGridViewAppointmentDetails = new System.Windows.Forms.DataGridView();
            this.btnfullfilled = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(1438, 13);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(92, 49);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Accepted";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // dropButton
            // 
            this.dropButton.Location = new System.Drawing.Point(1438, 80);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(92, 49);
            this.dropButton.TabIndex = 3;
            this.dropButton.Text = "Rejected";
            this.dropButton.UseVisualStyleBackColor = true;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // dataGridViewAppointmentDetails
            // 
            this.dataGridViewAppointmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentDetails.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewAppointmentDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAppointmentDetails.Name = "dataGridViewAppointmentDetails";
            this.dataGridViewAppointmentDetails.RowHeadersWidth = 51;
            this.dataGridViewAppointmentDetails.Size = new System.Drawing.Size(1418, 556);
            this.dataGridViewAppointmentDetails.TabIndex = 4;
            // 
            // btnfullfilled
            // 
            this.btnfullfilled.Location = new System.Drawing.Point(1438, 156);
            this.btnfullfilled.Name = "btnfullfilled";
            this.btnfullfilled.Size = new System.Drawing.Size(92, 49);
            this.btnfullfilled.TabIndex = 3;
            this.btnfullfilled.Text = "Fullfilled";
            this.btnfullfilled.UseVisualStyleBackColor = true;
            this.btnfullfilled.Click += new System.EventHandler(this.btnfullfilled_Click);
            // 
            // BarberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 582);
            this.Controls.Add(this.dataGridViewAppointmentDetails);
            this.Controls.Add(this.btnfullfilled);
            this.Controls.Add(this.dropButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "BarberForm";
            this.Text = "BarberForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.DataGridView dataGridViewAppointmentDetails;
        private System.Windows.Forms.Button btnfullfilled;
    }
}