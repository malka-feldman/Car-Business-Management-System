namespace UI
{
    partial class usercreate
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
            this.ProdNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.CPUTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.ProdNumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProdNameTextBox
            // 
            this.ProdNameTextBox.Location = new System.Drawing.Point(900, 395);
            this.ProdNameTextBox.Name = "ProdNameTextBox";
            this.ProdNameTextBox.Size = new System.Drawing.Size(100, 38);
            this.ProdNameTextBox.TabIndex = 0;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(684, 395);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(187, 32);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "product name";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Location = new System.Drawing.Point(703, 465);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(168, 32);
            this.CPULabel.TabIndex = 2;
            this.CPULabel.Text = "cost per unit";
            this.CPULabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CPUTextBox
            // 
            this.CPUTextBox.Location = new System.Drawing.Point(900, 465);
            this.CPUTextBox.Name = "CPUTextBox";
            this.CPUTextBox.Size = new System.Drawing.Size(100, 38);
            this.CPUTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 182);
            this.button1.TabIndex = 4;
            this.button1.Text = "create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.Location = new System.Drawing.Point(684, 341);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(212, 32);
            this.ProductNumberLabel.TabIndex = 5;
            this.ProductNumberLabel.Text = "product number";
            // 
            // ProdNumTextBox
            // 
            this.ProdNumTextBox.Location = new System.Drawing.Point(902, 335);
            this.ProdNumTextBox.Name = "ProdNumTextBox";
            this.ProdNumTextBox.Size = new System.Drawing.Size(100, 38);
            this.ProdNumTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount In Stock";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(902, 283);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 38);
            this.AmountTextBox.TabIndex = 8;
            // 
            // usercreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 841);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProdNumTextBox);
            this.Controls.Add(this.ProductNumberLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CPUTextBox);
            this.Controls.Add(this.CPULabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProdNameTextBox);
            this.Name = "usercreate";
            this.Text = "usercreate";
            this.Load += new System.EventHandler(this.usercreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProdNameTextBox;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.TextBox CPUTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.TextBox ProdNumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}