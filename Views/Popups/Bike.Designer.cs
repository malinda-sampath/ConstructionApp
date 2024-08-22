namespace ConstructionApp.Views.Popups
{
    partial class Bike
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
            bikeUpdateBtn = new Button();
            bikeNewInsurance = new DateTimePicker();
            bikeNewLicense = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            bikeInsurance = new Label();
            label4 = new Label();
            bikeLicense = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bikeUpdateBtn
            // 
            bikeUpdateBtn.BackColor = SystemColors.ActiveCaption;
            bikeUpdateBtn.Cursor = Cursors.Hand;
            bikeUpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bikeUpdateBtn.Location = new Point(445, 771);
            bikeUpdateBtn.Margin = new Padding(4, 4, 4, 4);
            bikeUpdateBtn.Name = "bikeUpdateBtn";
            bikeUpdateBtn.Size = new Size(175, 69);
            bikeUpdateBtn.TabIndex = 23;
            bikeUpdateBtn.Text = "Update";
            bikeUpdateBtn.UseVisualStyleBackColor = false;
            bikeUpdateBtn.Click += bikeUpdateBtn_Click;
            // 
            // bikeNewInsurance
            // 
            bikeNewInsurance.Location = new Point(24, 529);
            bikeNewInsurance.Margin = new Padding(4, 4, 4, 4);
            bikeNewInsurance.Name = "bikeNewInsurance";
            bikeNewInsurance.Size = new Size(396, 31);
            bikeNewInsurance.TabIndex = 22;
            // 
            // bikeNewLicense
            // 
            bikeNewLicense.Location = new Point(24, 429);
            bikeNewLicense.Margin = new Padding(4, 4, 4, 4);
            bikeNewLicense.Name = "bikeNewLicense";
            bikeNewLicense.Size = new Size(396, 31);
            bikeNewLicense.TabIndex = 21;
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
            // bikeInsurance
            // 
            bikeInsurance.AutoSize = true;
            bikeInsurance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bikeInsurance.Location = new Point(375, 204);
            bikeInsurance.Margin = new Padding(4, 0, 4, 0);
            bikeInsurance.Name = "bikeInsurance";
            bikeInsurance.Size = new Size(216, 28);
            bikeInsurance.TabIndex = 16;
            bikeInsurance.Text = "Insurance Renewal Date";
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
            // bikeLicense
            // 
            bikeLicense.AutoSize = true;
            bikeLicense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bikeLicense.Location = new Point(375, 135);
            bikeLicense.Margin = new Padding(4, 0, 4, 0);
            bikeLicense.Name = "bikeLicense";
            bikeLicense.Size = new Size(196, 28);
            bikeLicense.TabIndex = 14;
            bikeLicense.Text = "License Renewal Date";
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
            label2.Location = new Point(215, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 40);
            label2.TabIndex = 2;
            label2.Text = "WS - 6751";
            // 
            // Bike
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 860);
            Controls.Add(bikeUpdateBtn);
            Controls.Add(bikeNewInsurance);
            Controls.Add(bikeNewLicense);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(bikeInsurance);
            Controls.Add(label4);
            Controls.Add(bikeLicense);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Bike";
            Text = "Bike";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bikeUpdateBtn;
        private DateTimePicker bikeNewInsurance;
        private DateTimePicker bikeNewLicense;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label bikeInsurance;
        private Label label4;
        private Label bikeLicense;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}