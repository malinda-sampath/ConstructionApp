namespace ConstructionApp.Views.Popups
{
    partial class Cab
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
            cabUpdateBtn = new Button();
            cabNewInsurance = new DateTimePicker();
            cabNewLicense = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cabInsurance = new Label();
            label4 = new Label();
            cabLicense = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cabUpdateBtn
            // 
            cabUpdateBtn.BackColor = SystemColors.ActiveCaption;
            cabUpdateBtn.Cursor = Cursors.Hand;
            cabUpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cabUpdateBtn.Location = new Point(445, 771);
            cabUpdateBtn.Margin = new Padding(4, 4, 4, 4);
            cabUpdateBtn.Name = "cabUpdateBtn";
            cabUpdateBtn.Size = new Size(175, 69);
            cabUpdateBtn.TabIndex = 23;
            cabUpdateBtn.Text = "Update";
            cabUpdateBtn.UseVisualStyleBackColor = false;
            cabUpdateBtn.Click += cabUpdateBtn_Click;
            // 
            // cabNewInsurance
            // 
            cabNewInsurance.Location = new Point(24, 529);
            cabNewInsurance.Margin = new Padding(4, 4, 4, 4);
            cabNewInsurance.Name = "cabNewInsurance";
            cabNewInsurance.Size = new Size(396, 31);
            cabNewInsurance.TabIndex = 22;
            // 
            // cabNewLicense
            // 
            cabNewLicense.Location = new Point(24, 429);
            cabNewLicense.Margin = new Padding(4, 4, 4, 4);
            cabNewLicense.Name = "cabNewLicense";
            cabNewLicense.Size = new Size(396, 31);
            cabNewLicense.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 489);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(260, 28);
            label9.TabIndex = 20;
            label9.Text = "New Insurance Renewal Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 390);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(240, 28);
            label8.TabIndex = 19;
            label8.Text = "New License Renewal Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ScrollBar;
            label7.Location = new Point(24, 264);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(492, 28);
            label7.TabIndex = 18;
            label7.Text = "____________________________________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(162, 319);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(253, 31);
            label6.TabIndex = 17;
            label6.Text = "Update Renewal Dates";
            // 
            // cabInsurance
            // 
            cabInsurance.AutoSize = true;
            cabInsurance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cabInsurance.Location = new Point(375, 204);
            cabInsurance.Margin = new Padding(4, 0, 4, 0);
            cabInsurance.Name = "cabInsurance";
            cabInsurance.Size = new Size(216, 28);
            cabInsurance.TabIndex = 16;
            cabInsurance.Text = "Insurance Renewal Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 204);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(216, 28);
            label4.TabIndex = 15;
            label4.Text = "Insurance Renewal Date";
            // 
            // cabLicense
            // 
            cabLicense.AutoSize = true;
            cabLicense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cabLicense.Location = new Point(375, 135);
            cabLicense.Margin = new Padding(4, 0, 4, 0);
            cabLicense.Name = "cabLicense";
            cabLicense.Size = new Size(196, 28);
            cabLicense.TabIndex = 14;
            cabLicense.Text = "License Renewal Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 13;
            label1.Text = "License Renewal Date";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 81);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(196, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 40);
            label2.TabIndex = 2;
            label2.Text = "DAH - 1931";
            // 
            // Cab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 860);
            Controls.Add(cabUpdateBtn);
            Controls.Add(cabNewInsurance);
            Controls.Add(cabNewLicense);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cabInsurance);
            Controls.Add(label4);
            Controls.Add(cabLicense);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Cab";
            Text = "Cab";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cabUpdateBtn;
        private DateTimePicker cabNewInsurance;
        private DateTimePicker cabNewLicense;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label cabInsurance;
        private Label label4;
        private Label cabLicense;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}