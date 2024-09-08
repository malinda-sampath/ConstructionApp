namespace ConstructionApp.Views
{
    partial class EmployeeDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            panel1 = new Panel();
            button2 = new Button();
            employeeBtn = new Button();
            overviewBtn = new Button();
            label2 = new Label();
            payroll1 = new EmployeeSection.Payroll();
            employee1 = new EmployeeSection.Employee();
            overview1 = new EmployeeSection.Overview();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(employeeBtn);
            panel1.Controls.Add(overviewBtn);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 80);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1036, 20);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(185, 40);
            button2.TabIndex = 7;
            button2.Text = "Payroll";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.BackColor = SystemColors.Control;
            employeeBtn.Cursor = Cursors.Hand;
            employeeBtn.Font = new Font("Segoe UI", 12F);
            employeeBtn.Image = (Image)resources.GetObject("employeeBtn.Image");
            employeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            employeeBtn.Location = new Point(820, 20);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Padding = new Padding(10, 0, 0, 0);
            employeeBtn.Size = new Size(185, 40);
            employeeBtn.TabIndex = 6;
            employeeBtn.Text = "Employee";
            employeeBtn.UseVisualStyleBackColor = true;
            employeeBtn.Click += employeeBtn_Click;
            // 
            // overviewBtn
            // 
            overviewBtn.BackColor = SystemColors.Control;
            overviewBtn.Cursor = Cursors.Hand;
            overviewBtn.Font = new Font("Segoe UI", 12F);
            overviewBtn.Image = (Image)resources.GetObject("overviewBtn.Image");
            overviewBtn.ImageAlign = ContentAlignment.MiddleLeft;
            overviewBtn.Location = new Point(604, 20);
            overviewBtn.Name = "overviewBtn";
            overviewBtn.Padding = new Padding(10, 0, 0, 0);
            overviewBtn.Size = new Size(185, 40);
            overviewBtn.TabIndex = 5;
            overviewBtn.Text = "Overview";
            overviewBtn.UseVisualStyleBackColor = false;
            overviewBtn.Click += overviewBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(16, 21);
            label2.Name = "label2";
            label2.Size = new Size(329, 37);
            label2.TabIndex = 0;
            label2.Text = "Employee Management";
            // 
            // payroll1
            // 
            payroll1.Location = new Point(0, 83);
            payroll1.Name = "payroll1";
            payroll1.Size = new Size(1248, 770);
            payroll1.TabIndex = 3;
            // 
            // employee1
            // 
            employee1.Location = new Point(0, 83);
            employee1.Name = "employee1";
            employee1.Size = new Size(1248, 770);
            employee1.TabIndex = 4;
            // 
            // overview1
            // 
            overview1.Font = new Font("Segoe UI", 9F);
            overview1.Location = new Point(0, 83);
            overview1.Name = "overview1";
            overview1.Size = new Size(1248, 770);
            overview1.TabIndex = 5;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(overview1);
            Controls.Add(employee1);
            Controls.Add(payroll1);
            Controls.Add(panel1);
            Name = "EmployeeDashboard";
            Size = new Size(1248, 853);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private EmployeeSection.Payroll payroll1;
        private EmployeeSection.Employee employee1;
        private EmployeeSection.Overview overview1;
        private Button overviewBtn;
        private Button button2;
        private Button employeeBtn;
    }
}
