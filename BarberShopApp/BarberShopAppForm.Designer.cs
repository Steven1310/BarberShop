namespace BarberShopApp
{
    partial class BarberShopAppForm
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
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonBarber = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(157, 224);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(216, 46);
            this.buttonUser.TabIndex = 0;
            this.buttonUser.Text = "User";
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // buttonBarber
            // 
            this.buttonBarber.Location = new System.Drawing.Point(415, 224);
            this.buttonBarber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBarber.Name = "buttonBarber";
            this.buttonBarber.Size = new System.Drawing.Size(216, 46);
            this.buttonBarber.TabIndex = 1;
            this.buttonBarber.Text = "Barber";
            this.buttonBarber.UseVisualStyleBackColor = true;
            this.buttonBarber.Click += new System.EventHandler(this.buttonBarber_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(673, 224);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(216, 46);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // BarberShopAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonBarber);
            this.Controls.Add(this.buttonUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BarberShopAppForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonBarber;
        private System.Windows.Forms.Button buttonAdmin;
    }
}

