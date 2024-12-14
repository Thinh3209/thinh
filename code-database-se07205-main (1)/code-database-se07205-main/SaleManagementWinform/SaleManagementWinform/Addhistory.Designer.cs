namespace SaleManagementWinform
{
    partial class Addhistory
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
            this.button2 = new System.Windows.Forms.Button();
            this.tbx_purchaseID = new System.Windows.Forms.TextBox();
            this.tbx_customerCode = new System.Windows.Forms.TextBox();
            this.tbx_productCode = new System.Windows.Forms.TextBox();
            this.tbx_purchaseDate = new System.Windows.Forms.TextBox();
            this.tbx_quantity = new System.Windows.Forms.TextBox();
            this.tbx_status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbx_purchaseID
            // 
            this.tbx_purchaseID.Location = new System.Drawing.Point(147, 24);
            this.tbx_purchaseID.Multiline = true;
            this.tbx_purchaseID.Name = "tbx_purchaseID";
            this.tbx_purchaseID.Size = new System.Drawing.Size(177, 36);
            this.tbx_purchaseID.TabIndex = 2;
            // 
            // tbx_customerCode
            // 
            this.tbx_customerCode.Location = new System.Drawing.Point(147, 92);
            this.tbx_customerCode.Multiline = true;
            this.tbx_customerCode.Name = "tbx_customerCode";
            this.tbx_customerCode.Size = new System.Drawing.Size(177, 36);
            this.tbx_customerCode.TabIndex = 3;
            // 
            // tbx_productCode
            // 
            this.tbx_productCode.Location = new System.Drawing.Point(147, 165);
            this.tbx_productCode.Multiline = true;
            this.tbx_productCode.Name = "tbx_productCode";
            this.tbx_productCode.Size = new System.Drawing.Size(177, 36);
            this.tbx_productCode.TabIndex = 4;
            // 
            // tbx_purchaseDate
            // 
            this.tbx_purchaseDate.Location = new System.Drawing.Point(147, 234);
            this.tbx_purchaseDate.Multiline = true;
            this.tbx_purchaseDate.Name = "tbx_purchaseDate";
            this.tbx_purchaseDate.Size = new System.Drawing.Size(177, 36);
            this.tbx_purchaseDate.TabIndex = 5;
            // 
            // tbx_quantity
            // 
            this.tbx_quantity.Location = new System.Drawing.Point(147, 307);
            this.tbx_quantity.Multiline = true;
            this.tbx_quantity.Name = "tbx_quantity";
            this.tbx_quantity.Size = new System.Drawing.Size(177, 36);
            this.tbx_quantity.TabIndex = 6;
            // 
            // tbx_status
            // 
            this.tbx_status.Location = new System.Drawing.Point(147, 382);
            this.tbx_status.Multiline = true;
            this.tbx_status.Name = "tbx_status";
            this.tbx_status.Size = new System.Drawing.Size(177, 36);
            this.tbx_status.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "PurchaseID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "CustomerCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ProductCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "PurchaseDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status";
            // 
            // Addhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaleManagementWinform.Properties.Resources.Screenshot_2024_11_29_064140;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 513);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_status);
            this.Controls.Add(this.tbx_quantity);
            this.Controls.Add(this.tbx_purchaseDate);
            this.Controls.Add(this.tbx_productCode);
            this.Controls.Add(this.tbx_customerCode);
            this.Controls.Add(this.tbx_purchaseID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Addhistory";
            this.Text = "Addhistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbx_purchaseID;
        private System.Windows.Forms.TextBox tbx_customerCode;
        private System.Windows.Forms.TextBox tbx_productCode;
        private System.Windows.Forms.TextBox tbx_purchaseDate;
        private System.Windows.Forms.TextBox tbx_quantity;
        private System.Windows.Forms.TextBox tbx_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}