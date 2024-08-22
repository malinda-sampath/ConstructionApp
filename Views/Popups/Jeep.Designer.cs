namespace ConstructionApp.Views.Popups
{
    partial class Jeep
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
            jeepUpdateBtn = new Button();
            jeepNewInsurance = new DateTimePicker();
            jeepNewLicense = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            jeepInsurance = new Label();
            label4 = new Label();
            jeepLicense = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // jeepUpdateBtn
            // 
            jeepUpdateBtn.BackColor = SystemColors.ActiveCaption;
            jeepUpdateBtn.Cursor = Cursors.Hand;
            jeepUpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jeepUpdateBtn.Location = new Point(445, 771);
            jeepUpdateBtn.Margin = new Padding(4, 4, 4, 4);
            jeepUpdateBtn.Name = "jeepUpdateBtn";
            jeepUpdateBtn.Size = new Size(175, 69);
            jeepUpdateBtn.TabIndex = 23;
            jeepUpdateBtn.Text = "Update";
            jeepUpdateBtn.UseVisualStyleBackColor = false;
            jeepUpdateBtn.Click += jeepUpdateBtn_Click;
            // 
            // jeepNewInsurance
            // 
            jeepNewInsurance.Location = new Point(24, 529);
            jeepNewInsurance.Margin = new Padding(4, 4, 4, 4);
            jeepNewInsurance.Name = "jeepNewInsurance";
            jeepNewInsurance.Size = new Size(396, 31);
            jeepNewInsurance.TabIndex = 22;
            // 
            // jeepNewLicense
            // 
            jeepNewLicense.Location = new Point(24, 429);
            jeepNewLicense.Margin = new Padding(4, 4, 4, 4);
            jeepNewLicense.Name = "jeepNewLicense";
            jeepNewLicense.Size = new Size(396, 31);
            jeepNewLicense.TabIndex = 21;
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
            // jeepInsurance
            // 
            jeepInsurance.AutoSize = true;
            jeepInsurance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jeepInsurance.Location = new Point(375, 204);
            jeepInsurance.Margin = new Padding(4, 0, 4, 0);
            jeepInsurance.Name = "jeepInsurance";
            jeepInsurance.Size = new Size(216, 28);
            jeepInsurance.TabIndex = 16;
            jeepInsurance.Text = "Insurance Renewal Date";
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
            // jeepLicense
            // 
            jeepLicense.AutoSize = true;
            jeepLicense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jeepLicense.Location = new Point(375, 135);
            jeepLicense.Margin = new Padding(4, 0, 4, 0);
            jeepLicense.Name = "jeepLicense";
            jeepLicense.Size = new Size(196, 28);
            jeepLicense.TabIndex = 14;
            jeepLicense.Text = "License Renewal Date";
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
            label2.Text = "KQ - 9995";
            // 
            // Jeep
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 860);
            Controls.Add(jeepUpdateBtn);
            Controls.Add(jeepNewInsurance);
            Controls.Add(jeepNewLicense);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(jeepInsurance);
            Controls.Add(label4);
            Controls.Add(jeepLicense);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Jeep";
            Text = "Jeep";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button jeepUpdateBtn;
        private DateTimePicker jeepNewInsurance;
        private DateTimePicker jeepNewLicense;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label jeepInsurance;
        private Label label4;
        private Label jeepLicense;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}