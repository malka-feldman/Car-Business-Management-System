namespace UI
{
    partial class CustomerForm
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
            this.CustomerIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.CustomerNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShowLabel = new System.Windows.Forms.Label();
            this.ShowLeb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(137, 134);
            this.CustomerIDTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(40, 20);
            this.CustomerIDTextBox.TabIndex = 15;
            this.CustomerIDTextBox.Visible = false;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.BackColor = System.Drawing.Color.Black;
            this.CustomerIDLabel.ForeColor = System.Drawing.Color.White;
            this.CustomerIDLabel.Location = new System.Drawing.Point(40, 135);
            this.CustomerIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLabel.TabIndex = 14;
            this.CustomerIDLabel.Text = "Customer ID";
            this.CustomerIDLabel.Visible = false;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.HotPink;
            this.createButton.Location = new System.Drawing.Point(352, 162);
            this.createButton.Margin = new System.Windows.Forms.Padding(1);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(47, 35);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Visible = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(137, 86);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(40, 20);
            this.CustomerNameTextBox.TabIndex = 12;
            this.CustomerNameTextBox.Visible = false;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.White;
            this.CustomerNameLabel.Location = new System.Drawing.Point(40, 86);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CustomerNameLabel.TabIndex = 11;
            this.CustomerNameLabel.Text = "Customer Name";
            this.CustomerNameLabel.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.HotPink;
            this.DeleteButton.Location = new System.Drawing.Point(352, 75);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(1);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(47, 35);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.HotPink;
            this.Find.Location = new System.Drawing.Point(352, 120);
            this.Find.Margin = new System.Windows.Forms.Padding(1);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(47, 35);
            this.Find.TabIndex = 17;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Visible = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.HotPink;
            this.Update.Location = new System.Drawing.Point(352, 204);
            this.Update.Margin = new System.Windows.Forms.Padding(1);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(57, 35);
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Visible = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.HotPink;
            this.ShowButton.Location = new System.Drawing.Point(352, 242);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(1);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(47, 35);
            this.ShowButton.TabIndex = 19;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Visible = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ShowLabel
            // 
            this.ShowLabel.AutoSize = true;
            this.ShowLabel.Location = new System.Drawing.Point(357, 292);
            this.ShowLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(0, 13);
            this.ShowLabel.TabIndex = 20;
            // 
            // ShowLeb
            // 
            this.ShowLeb.AutoSize = true;
            this.ShowLeb.Location = new System.Drawing.Point(406, 379);
            this.ShowLeb.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ShowLeb.Name = "ShowLeb";
            this.ShowLeb.Size = new System.Drawing.Size(35, 13);
            this.ShowLeb.TabIndex = 21;
            this.ShowLeb.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(300, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(689, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowLeb);
            this.Controls.Add(this.ShowLabel);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.Controls.SetChildIndex(this.CustomerNameLabel, 0);
            this.Controls.SetChildIndex(this.CustomerNameTextBox, 0);
            this.Controls.SetChildIndex(this.createButton, 0);
            this.Controls.SetChildIndex(this.CustomerIDLabel, 0);
            this.Controls.SetChildIndex(this.CustomerIDTextBox, 0);
            this.Controls.SetChildIndex(this.DeleteButton, 0);
            this.Controls.SetChildIndex(this.Find, 0);
            this.Controls.SetChildIndex(this.Update, 0);
            this.Controls.SetChildIndex(this.ShowButton, 0);
            this.Controls.SetChildIndex(this.ShowLabel, 0);
            this.Controls.SetChildIndex(this.ShowLeb, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox CustomerIDTextBox;
        public System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.MaskedTextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.Label ShowLeb;
        private System.Windows.Forms.Label label1;
    }
}