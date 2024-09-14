namespace ConstructionApp.Views.Popups
{
    partial class RenewalPopup
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
            vehicleUpdateBtn = new Button();
            vehicleNewInsurance = new DateTimePicker();
            vehicleNewLicense = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            vehicleInsurance = new Label();
            label4 = new Label();
            vehicleLicense = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblRegNo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // vehicleUpdateBtn
            // 
            vehicleUpdateBtn.BackColor = SystemColors.ActiveCaption;
            vehicleUpdateBtn.Cursor = Cursors.Hand;
            vehicleUpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vehicleUpdateBtn.Location = new Point(445, 781);
            vehicleUpdateBtn.Margin = new Padding(4);
            vehicleUpdateBtn.Name = "vehicleUpdateBtn";
            vehicleUpdateBtn.Size = new Size(175, 69);
            vehicleUpdateBtn.TabIndex = 35;
            vehicleUpdateBtn.Text = "Update";
            vehicleUpdateBtn.UseVisualStyleBackColor = false;
            vehicleUpdateBtn.Click += vehicleUpdateBtn_Click;
            // 
            // vehicleNewInsurance
            // 
            vehicleNewInsurance.Location = new Point(24, 539);
            vehicleNewInsurance.Margin = new Padding(4);
            vehicleNewInsurance.Name = "vehicleNewInsurance";
            vehicleNewInsurance.Size = new Size(396, 31);
            vehicleNewInsurance.TabIndex = 34;
            // 
            // vehicleNewLicense
            // 
            vehicleNewLicense.Location = new Point(24, 439);
            vehicleNewLicense.Margin = new Padding(4);
            vehicleNewLicense.Name = "vehicleNewLicense";
            vehicleNewLicense.Size = new Size(396, 31);
            vehicleNewLicense.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 499);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(260, 28);
            label9.TabIndex = 32;
            label9.Text = "New Insurance Renewal Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 400);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(240, 28);
            label8.TabIndex = 31;
            label8.Text = "New License Renewal Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ScrollBar;
            label7.Location = new Point(24, 274);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(492, 28);
            label7.TabIndex = 30;
            label7.Text = "____________________________________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(162, 329);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(253, 31);
            label6.TabIndex = 29;
            label6.Text = "Update Renewal Dates";
            // 
            // vehicleInsurance
            // 
            vehicleInsurance.AutoSize = true;
            vehicleInsurance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vehicleInsurance.Location = new Point(375, 214);
            vehicleInsurance.Margin = new Padding(4, 0, 4, 0);
            vehicleInsurance.Name = "vehicleInsurance";
            vehicleInsurance.Size = new Size(216, 28);
            vehicleInsurance.TabIndex = 28;
            vehicleInsurance.Text = "Insurance Renewal Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 214);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(216, 28);
            label4.TabIndex = 27;
            label4.Text = "Insurance Renewal Date";
            // 
            // vehicleLicense
            // 
            vehicleLicense.AutoSize = true;
            vehicleLicense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vehicleLicense.Location = new Point(375, 145);
            vehicleLicense.Margin = new Padding(4, 0, 4, 0);
            vehicleLicense.Name = "vehicleLicense";
            vehicleLicense.Size = new Size(196, 28);
            vehicleLicense.TabIndex = 26;
            vehicleLicense.Text = "License Renewal Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 145);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 25;
            label1.Text = "License Renewal Date";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(lblRegNo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 81);
            panel1.TabIndex = 24;
            // 
            // lblRegNo
            // 
            lblRegNo.AutoSize = true;
            lblRegNo.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegNo.Location = new Point(263, 19);
            lblRegNo.Margin = new Padding(4, 0, 4, 0);
            lblRegNo.Name = "lblRegNo";
            lblRegNo.Size = new Size(136, 40);
            lblRegNo.TabIndex = 2;
            lblRegNo.Text = "reg No";
            // 
            // RenewalPopup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 860);
            Controls.Add(vehicleUpdateBtn);
            Controls.Add(vehicleNewInsurance);
            Controls.Add(vehicleNewLicense);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(vehicleInsurance);
            Controls.Add(label4);
            Controls.Add(vehicleLicense);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "RenewalPopup";
            Text = "RenewalPopup";
            Load += RenewalPopup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button vehicleUpdateBtn;
        private DateTimePicker vehicleNewInsurance;
        private DateTimePicker vehicleNewLicense;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label vehicleInsurance;
        private Label label4;
        private Label vehicleLicense;
        private Label label1;
        private Panel panel1;
        private Label lblRegNo;
    }
}