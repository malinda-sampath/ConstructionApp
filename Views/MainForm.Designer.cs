namespace ConstructionApp.Views
{
    partial class MainForm
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
            leftSidePanel = new Panel();
            settingsBtn = new Button();
            logoutBtn = new Button();
            vehiclesBtn = new Button();
            officeBtn = new Button();
            employeeBtn = new Button();
            sitesBtn = new Button();
            dashboardBtn = new Button();
            panel1 = new Panel();
            dashboard1 = new Dashboard();
            employeeDashboard1 = new EmployeeDashboard();
            sites1 = new Sites();
            office1 = new Office();
            vehicleForm1 = new VehicleForm();
            leftSidePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftSidePanel
            // 
            leftSidePanel.BackColor = Color.FromArgb(0, 74, 173);
            leftSidePanel.Controls.Add(settingsBtn);
            leftSidePanel.Controls.Add(logoutBtn);
            leftSidePanel.Controls.Add(vehiclesBtn);
            leftSidePanel.Controls.Add(officeBtn);
            leftSidePanel.Controls.Add(employeeBtn);
            leftSidePanel.Controls.Add(sitesBtn);
            leftSidePanel.Controls.Add(dashboardBtn);
            leftSidePanel.Dock = DockStyle.Left;
            leftSidePanel.Location = new Point(0, 0);
            leftSidePanel.Name = "leftSidePanel";
            leftSidePanel.Size = new Size(334, 853);
            leftSidePanel.TabIndex = 0;
            // 
            // settingsBtn
            // 
            settingsBtn.Cursor = Cursors.Hand;
            settingsBtn.Image = Properties.Resources.Settings;
            settingsBtn.Location = new Point(260, 777);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(50, 50);
            settingsBtn.TabIndex = 6;
            settingsBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Image = Properties.Resources.LogoutIcon;
            logoutBtn.Location = new Point(22, 777);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(50, 50);
            logoutBtn.TabIndex = 5;
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // vehiclesBtn
            // 
            vehiclesBtn.Cursor = Cursors.Hand;
            vehiclesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vehiclesBtn.Image = Properties.Resources.VehicleIcon;
            vehiclesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            vehiclesBtn.Location = new Point(22, 493);
            vehiclesBtn.Name = "vehiclesBtn";
            vehiclesBtn.Padding = new Padding(20, 0, 0, 0);
            vehiclesBtn.Size = new Size(288, 46);
            vehiclesBtn.TabIndex = 4;
            vehiclesBtn.Text = "Vehicles";
            vehiclesBtn.UseVisualStyleBackColor = true;
            vehiclesBtn.Click += vehiclesBtn_Click;
            // 
            // officeBtn
            // 
            officeBtn.Cursor = Cursors.Hand;
            officeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            officeBtn.Image = Properties.Resources.OfficeIcon;
            officeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            officeBtn.Location = new Point(22, 428);
            officeBtn.Name = "officeBtn";
            officeBtn.Padding = new Padding(20, 0, 0, 0);
            officeBtn.Size = new Size(288, 46);
            officeBtn.TabIndex = 3;
            officeBtn.Text = "Office";
            officeBtn.UseVisualStyleBackColor = true;
            officeBtn.Click += officeBtn_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.Cursor = Cursors.Hand;
            employeeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeBtn.Image = Properties.Resources.EmployeeIcon;
            employeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            employeeBtn.Location = new Point(22, 361);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Padding = new Padding(20, 0, 0, 0);
            employeeBtn.Size = new Size(288, 46);
            employeeBtn.TabIndex = 2;
            employeeBtn.Text = "Employee";
            employeeBtn.UseVisualStyleBackColor = true;
            employeeBtn.Click += employeeBtn_Click;
            // 
            // sitesBtn
            // 
            sitesBtn.Cursor = Cursors.Hand;
            sitesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sitesBtn.Image = Properties.Resources.Sites;
            sitesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            sitesBtn.Location = new Point(22, 295);
            sitesBtn.Name = "sitesBtn";
            sitesBtn.Padding = new Padding(20, 0, 0, 0);
            sitesBtn.Size = new Size(288, 46);
            sitesBtn.TabIndex = 1;
            sitesBtn.Text = "Sites";
            sitesBtn.UseVisualStyleBackColor = true;
            sitesBtn.Click += sitesBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Cursor = Cursors.Hand;
            dashboardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardBtn.Image = Properties.Resources.DashboardIcon;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(22, 231);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(20, 0, 0, 0);
            dashboardBtn.Size = new Size(288, 46);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dashboard1);
            panel1.Controls.Add(employeeDashboard1);
            panel1.Controls.Add(sites1);
            panel1.Controls.Add(office1);
            panel1.Controls.Add(vehicleForm1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(334, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 853);
            panel1.TabIndex = 1;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1248, 853);
            dashboard1.TabIndex = 6;
            // 
            // employeeDashboard1
            // 
            employeeDashboard1.Location = new Point(0, 0);
            employeeDashboard1.Name = "employeeDashboard1";
            employeeDashboard1.Size = new Size(1248, 853);
            employeeDashboard1.TabIndex = 5;
            // 
            // sites1
            // 
            sites1.Location = new Point(0, 0);
            sites1.Name = "sites1";
            sites1.Size = new Size(1248, 853);
            sites1.TabIndex = 3;
            // 
            // office1
            // 
            office1.Location = new Point(0, 0);
            office1.Name = "office1";
            office1.Size = new Size(1248, 853);
            office1.TabIndex = 1;
            // 
            // vehicleForm1
            // 
            vehicleForm1.BackColor = SystemColors.ControlLight;
            vehicleForm1.Location = new Point(0, 0);
            vehicleForm1.Name = "vehicleForm1";
            vehicleForm1.Size = new Size(1248, 853);
            vehicleForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Controls.Add(leftSidePanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABC Constructions (pvt) ltd.";
            Load += MainForm_Load;
            leftSidePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftSidePanel;
        private Button sitesBtn;
        private Button dashboardBtn;
        private Button vehiclesBtn;
        private Button officeBtn;
        private Button employeeBtn;
        private Button settingsBtn;
        private Button logoutBtn;
        private Panel panel1;
        private VehicleForm vehicleForm1;
        private Sites sites1;
        private Office office1;
        private EmployeeDashboard employeeDashboard1;
        private Dashboard dashboard1;
    }
}