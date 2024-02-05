namespace UI
{
    partial class ProductForm
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
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.ProductNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CPULabel = new System.Windows.Forms.Label();
            this.CPUTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShowLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductNumberLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProductNumberLabel.Location = new System.Drawing.Point(46, 85);
            this.ProductNumberLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.ProductNumberLabel.TabIndex = 3;
            this.ProductNumberLabel.Text = "Product Number";
            this.ProductNumberLabel.Visible = false;
            this.ProductNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductNumberTextBox
            // 
            this.ProductNumberTextBox.Location = new System.Drawing.Point(146, 85);
            this.ProductNumberTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ProductNumberTextBox.Name = "ProductNumberTextBox";
            this.ProductNumberTextBox.Size = new System.Drawing.Size(40, 20);
            this.ProductNumberTextBox.TabIndex = 4;
            this.ProductNumberTextBox.Visible = false;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.HotPink;
            this.enterButton.Location = new System.Drawing.Point(91, 191);
            this.enterButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(47, 35);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Create";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Visible = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProductNameLabel.Location = new System.Drawing.Point(46, 122);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(75, 13);
            this.ProductNameLabel.TabIndex = 6;
            this.ProductNameLabel.Text = "Product Name";
            this.ProductNameLabel.Visible = false;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(146, 120);
            this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(40, 20);
            this.ProductNameTextBox.TabIndex = 7;
            this.ProductNameTextBox.Visible = false;
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPULabel.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.CPULabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CPULabel.Location = new System.Drawing.Point(46, 155);
            this.CPULabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(87, 13);
            this.CPULabel.TabIndex = 8;
            this.CPULabel.Text = "Cost Per Unit    $";
            this.CPULabel.Visible = false;
            this.CPULabel.Click += new System.EventHandler(this.CPULabel_Click);
            // 
            // CPUTextBox
            // 
            this.CPUTextBox.Location = new System.Drawing.Point(146, 153);
            this.CPUTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CPUTextBox.Name = "CPUTextBox";
            this.CPUTextBox.Size = new System.Drawing.Size(40, 20);
            this.CPUTextBox.TabIndex = 9;
            this.CPUTextBox.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.HotPink;
            this.DeleteButton.Location = new System.Drawing.Point(140, 191);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(47, 35);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.HotPink;
            this.FindButton.Location = new System.Drawing.Point(42, 191);
            this.FindButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(47, 35);
            this.FindButton.TabIndex = 11;
            this.FindButton.TabStop = false;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Visible = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.HotPink;
            this.ShowButton.Location = new System.Drawing.Point(91, 239);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(83, 44);
            this.ShowButton.TabIndex = 12;
            this.ShowButton.Text = "Show All Products";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Visible = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ShowLabel
            // 
            this.ShowLabel.AutoSize = true;
            this.ShowLabel.Location = new System.Drawing.Point(94, 293);
            this.ShowLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(0, 13);
            this.ShowLabel.TabIndex = 13;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.HotPink;
            this.UpdateButton.Location = new System.Drawing.Point(194, 191);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(47, 35);
            this.UpdateButton.TabIndex = 14;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(458, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Amountlabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Amountlabel.Location = new System.Drawing.Point(203, 85);
            this.Amountlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(43, 13);
            this.Amountlabel.TabIndex = 16;
            this.Amountlabel.Text = "Amount";
            this.Amountlabel.Visible = false;
            this.Amountlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(251, 83);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(40, 20);
            this.amountTextBox.TabIndex = 17;
            this.amountTextBox.Visible = false;
            this.amountTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ShowLabel);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CPUTextBox);
            this.Controls.Add(this.CPULabel);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.ProductNumberTextBox);
            this.Controls.Add(this.ProductNumberLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Controls.SetChildIndex(this.ProductNumberLabel, 0);
            this.Controls.SetChildIndex(this.ProductNumberTextBox, 0);
            this.Controls.SetChildIndex(this.enterButton, 0);
            this.Controls.SetChildIndex(this.ProductNameLabel, 0);
            this.Controls.SetChildIndex(this.ProductNameTextBox, 0);
            this.Controls.SetChildIndex(this.CPULabel, 0);
            this.Controls.SetChildIndex(this.CPUTextBox, 0);
            this.Controls.SetChildIndex(this.DeleteButton, 0);
            this.Controls.SetChildIndex(this.FindButton, 0);
            this.Controls.SetChildIndex(this.ShowButton, 0);
            this.Controls.SetChildIndex(this.ShowLabel, 0);
            this.Controls.SetChildIndex(this.UpdateButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Amountlabel, 0);
            this.Controls.SetChildIndex(this.amountTextBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.MaskedTextBox ProductNumberTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.MaskedTextBox ProductNameTextBox;
        public System.Windows.Forms.Label ProductNameLabel;
        public System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.MaskedTextBox CPUTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.MaskedTextBox amountTextBox;
    }
}