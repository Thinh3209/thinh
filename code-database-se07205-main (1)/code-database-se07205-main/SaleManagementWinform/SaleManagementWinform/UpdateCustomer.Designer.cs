namespace SaleManagementWinform
{
    partial class UpdateCustomer
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_address = new System.Windows.Forms.TextBox();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_code = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(45, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(45, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "PhoneNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(45, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Code";
            // 
            // tbx_address
            // 
            this.tbx_address.Location = new System.Drawing.Point(176, 273);
            this.tbx_address.Multiline = true;
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(325, 49);
            this.tbx_address.TabIndex = 12;
            // 
            // tbx_phone
            // 
            this.tbx_phone.Location = new System.Drawing.Point(176, 189);
            this.tbx_phone.Multiline = true;
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.Size = new System.Drawing.Size(325, 49);
            this.tbx_phone.TabIndex = 11;
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(176, 103);
            this.tbx_name.Multiline = true;
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(325, 49);
            this.tbx_name.TabIndex = 10;
            // 
            // tbx_code
            // 
            this.tbx_code.Location = new System.Drawing.Point(176, 24);
            this.tbx_code.Multiline = true;
            this.tbx_code.Name = "tbx_code";
            this.tbx_code.Size = new System.Drawing.Size(325, 49);
            this.tbx_code.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 52);
            this.button2.TabIndex = 18;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::SaleManagementWinform.Properties.Resources.Screenshot_2024_11_29_064140;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_address);
            this.Controls.Add(this.tbx_phone);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.tbx_code);
            this.DoubleBuffered = true;
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_address;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_code;
        private System.Windows.Forms.Button button2;
    }
}