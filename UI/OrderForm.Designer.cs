namespace UI
{
    partial class OrderForm
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
            this.ShowLabel = new System.Windows.Forms.Label();
            this.ShowByCustomerButton = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CustomerIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.ProductNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.OrderQuantityTextBox = new System.Windows.Forms.MaskedTextBox();
            this.OrderQuantityLabel = new System.Windows.Forms.Label();
            this.OrderIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.ShowByProductButton = new System.Windows.Forms.Button();
            this.ShowButtonC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowButtonProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowLabel
            // 
            this.ShowLabel.AutoSize = true;
            this.ShowLabel.Location = new System.Drawing.Point(511, 328);
            this.ShowLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(0, 13);
            this.ShowLabel.TabIndex = 30;
            // 
            // ShowByCustomerButton
            // 
            this.ShowByCustomerButton.BackColor = System.Drawing.Color.HotPink;
            this.ShowByCustomerButton.Location = new System.Drawing.Point(506, 278);
            this.ShowByCustomerButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ShowByCustomerButton.Name = "ShowByCustomerButton";
            this.ShowByCustomerButton.Size = new System.Drawing.Size(84, 35);
            this.ShowByCustomerButton.TabIndex = 29;
            this.ShowByCustomerButton.Text = "Show By Customer";
            this.ShowByCustomerButton.UseVisualStyleBackColor = false;
            this.ShowByCustomerButton.Visible = false;
            this.ShowByCustomerButton.Click += new System.EventHandler(this.ShowByCustomerButton_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.HotPink;
            this.Update.Location = new System.Drawing.Point(506, 241);
            this.Update.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(57, 35);
            this.Update.TabIndex = 28;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Visible = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.HotPink;
            this.Find.Location = new System.Drawing.Point(506, 156);
            this.Find.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(47, 35);
            this.Find.TabIndex = 27;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Visible = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.HotPink;
            this.DeleteButton.Location = new System.Drawing.Point(506, 112);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(47, 35);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(134, 81);
            this.CustomerIDTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(40, 20);
            this.CustomerIDTextBox.TabIndex = 25;
            this.CustomerIDTextBox.Visible = false;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.BackColor = System.Drawing.Color.Black;
            this.CustomerIDLabel.ForeColor = System.Drawing.Color.White;
            this.CustomerIDLabel.Location = new System.Drawing.Point(36, 82);
            this.CustomerIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLabel.TabIndex = 24;
            this.CustomerIDLabel.Text = "Customer ID";
            this.CustomerIDLabel.Visible = false;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.HotPink;
            this.createButton.Location = new System.Drawing.Point(506, 199);
            this.createButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(47, 35);
            this.createButton.TabIndex = 23;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Visible = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.White;
            this.CustomerNameLabel.Location = new System.Drawing.Point(36, 33);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(0, 13);
            this.CustomerNameLabel.TabIndex = 21;
            this.CustomerNameLabel.Visible = false;
            // 
            // ProductNumberTextBox
            // 
            this.ProductNumberTextBox.Location = new System.Drawing.Point(134, 117);
            this.ProductNumberTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ProductNumberTextBox.Name = "ProductNumberTextBox";
            this.ProductNumberTextBox.Size = new System.Drawing.Size(40, 20);
            this.ProductNumberTextBox.TabIndex = 32;
            this.ProductNumberTextBox.Visible = false;
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductNumberLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProductNumberLabel.Location = new System.Drawing.Point(36, 117);
            this.ProductNumberLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.ProductNumberLabel.TabIndex = 31;
            this.ProductNumberLabel.Text = "Product Number";
            this.ProductNumberLabel.Visible = false;
            // 
            // OrderQuantityTextBox
            // 
            this.OrderQuantityTextBox.Location = new System.Drawing.Point(134, 149);
            this.OrderQuantityTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.OrderQuantityTextBox.Name = "OrderQuantityTextBox";
            this.OrderQuantityTextBox.Size = new System.Drawing.Size(40, 20);
            this.OrderQuantityTextBox.TabIndex = 34;
            this.OrderQuantityTextBox.Visible = false;
            // 
            // OrderQuantityLabel
            // 
            this.OrderQuantityLabel.AutoSize = true;
            this.OrderQuantityLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderQuantityLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OrderQuantityLabel.Location = new System.Drawing.Point(36, 151);
            this.OrderQuantityLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.OrderQuantityLabel.Name = "OrderQuantityLabel";
            this.OrderQuantityLabel.Size = new System.Drawing.Size(75, 13);
            this.OrderQuantityLabel.TabIndex = 33;
            this.OrderQuantityLabel.Text = "Order Quantity";
            this.OrderQuantityLabel.Visible = false;
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Location = new System.Drawing.Point(134, 181);
            this.OrderIdTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.Size = new System.Drawing.Size(40, 20);
            this.OrderIdTextBox.TabIndex = 36;
            this.OrderIdTextBox.Visible = false;
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.BackColor = System.Drawing.Color.Black;
            this.OrderIdLabel.ForeColor = System.Drawing.Color.White;
            this.OrderIdLabel.Location = new System.Drawing.Point(36, 184);
            this.OrderIdLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(47, 13);
            this.OrderIdLabel.TabIndex = 35;
            this.OrderIdLabel.Text = "Order ID";
            this.OrderIdLabel.Visible = false;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.BackColor = System.Drawing.Color.HotPink;
            this.ShowAllButton.Location = new System.Drawing.Point(506, 317);
            this.ShowAllButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(84, 35);
            this.ShowAllButton.TabIndex = 37;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Visible = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // ShowByProductButton
            // 
            this.ShowByProductButton.BackColor = System.Drawing.Color.HotPink;
            this.ShowByProductButton.Location = new System.Drawing.Point(506, 360);
            this.ShowByProductButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ShowByProductButton.Name = "ShowByProductButton";
            this.ShowByProductButton.Size = new System.Drawing.Size(84, 35);
            this.ShowByProductButton.TabIndex = 38;
            this.ShowByProductButton.Text = "Show By Product";
            this.ShowByProductButton.UseVisualStyleBackColor = false;
            this.ShowByProductButton.Visible = false;
            this.ShowByProductButton.Click += new System.EventHandler(this.ShowByProductButton_Click);
            // 
            // ShowButtonC
            // 
            this.ShowButtonC.BackColor = System.Drawing.Color.HotPink;
            this.ShowButtonC.Location = new System.Drawing.Point(506, 71);
            this.ShowButtonC.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ShowButtonC.Name = "ShowButtonC";
            this.ShowButtonC.Size = new System.Drawing.Size(47, 35);
            this.ShowButtonC.TabIndex = 39;
            this.ShowButtonC.Text = "Show";
            this.ShowButtonC.UseVisualStyleBackColor = false;
            this.ShowButtonC.Visible = false;
            this.ShowButtonC.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(342, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "label1";
            this.label1.UseWaitCursor = true;
            this.label1.Visible = false;
            // 
            // ShowButtonProd
            // 
            this.ShowButtonProd.BackColor = System.Drawing.Color.HotPink;
            this.ShowButtonProd.Location = new System.Drawing.Point(555, 71);
            this.ShowButtonProd.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ShowButtonProd.Name = "ShowButtonProd";
            this.ShowButtonProd.Size = new System.Drawing.Size(47, 35);
            this.ShowButtonProd.TabIndex = 41;
            this.ShowButtonProd.Text = "Show";
            this.ShowButtonProd.UseVisualStyleBackColor = false;
            this.ShowButtonProd.Visible = false;
            this.ShowButtonProd.Click += new System.EventHandler(this.ShowButtonProd_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.ShowButtonProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowButtonC);
            this.Controls.Add(this.ShowByProductButton);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.OrderIdTextBox);
            this.Controls.Add(this.OrderIdLabel);
            this.Controls.Add(this.OrderQuantityTextBox);
            this.Controls.Add(this.OrderQuantityLabel);
            this.Controls.Add(this.ProductNumberTextBox);
            this.Controls.Add(this.ProductNumberLabel);
            this.Controls.Add(this.ShowLabel);
            this.Controls.Add(this.ShowByCustomerButton);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.CustomerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "OrderForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Controls.SetChildIndex(this.CustomerNameLabel, 0);
            this.Controls.SetChildIndex(this.createButton, 0);
            this.Controls.SetChildIndex(this.CustomerIDLabel, 0);
            this.Controls.SetChildIndex(this.CustomerIDTextBox, 0);
            this.Controls.SetChildIndex(this.DeleteButton, 0);
            this.Controls.SetChildIndex(this.Find, 0);
            this.Controls.SetChildIndex(this.Update, 0);
            this.Controls.SetChildIndex(this.ShowByCustomerButton, 0);
            this.Controls.SetChildIndex(this.ShowLabel, 0);
            this.Controls.SetChildIndex(this.ProductNumberLabel, 0);
            this.Controls.SetChildIndex(this.ProductNumberTextBox, 0);
            this.Controls.SetChildIndex(this.OrderQuantityLabel, 0);
            this.Controls.SetChildIndex(this.OrderQuantityTextBox, 0);
            this.Controls.SetChildIndex(this.OrderIdLabel, 0);
            this.Controls.SetChildIndex(this.OrderIdTextBox, 0);
            this.Controls.SetChildIndex(this.ShowAllButton, 0);
            this.Controls.SetChildIndex(this.ShowByProductButton, 0);
            this.Controls.SetChildIndex(this.ShowButtonC, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ShowButtonProd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.Button ShowByCustomerButton;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.MaskedTextBox CustomerIDTextBox;
        public System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.MaskedTextBox ProductNumberTextBox;
        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.MaskedTextBox OrderQuantityTextBox;
        private System.Windows.Forms.Label OrderQuantityLabel;
        private System.Windows.Forms.MaskedTextBox OrderIdTextBox;
        public System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button ShowByProductButton;
        private System.Windows.Forms.Button ShowButtonC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowButtonProd;
    }
}