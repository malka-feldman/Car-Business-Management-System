namespace UI
{
    partial class MainMenu
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
            this.CustomerButton = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerButton
            // 
            this.CustomerButton.BackColor = System.Drawing.Color.HotPink;
            this.CustomerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerButton.Location = new System.Drawing.Point(44, 381);
            this.CustomerButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(409, 124);
            this.CustomerButton.TabIndex = 0;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = false;
            this.CustomerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.Color.HotPink;
            this.Product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product.Location = new System.Drawing.Point(44, 53);
            this.Product.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(409, 133);
            this.Product.TabIndex = 1;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = false;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.HotPink;
            this.orderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderButton.Location = new System.Drawing.Point(44, 220);
            this.orderButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(409, 127);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::UI.Properties.Resources.LASTT;
            this.pictureBox1.Location = new System.Drawing.Point(25, 809);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2486, 1374);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(3134, 1594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.CustomerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}