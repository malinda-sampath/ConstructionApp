namespace ConstructionApp.Views
{
    partial class RegisterForm
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            register_name = new TextBox();
            register_closeBtn = new PictureBox();
            register_username = new TextBox();
            register_password = new TextBox();
            register_loginBtn = new Label();
            register_showPassword = new CheckBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)register_closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.RegisterForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1125, 750);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 74, 173);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 89, 171);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 89, 171);
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(134, 615);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(194, 60);
            button1.TabIndex = 10;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // register_name
            // 
            register_name.BorderStyle = BorderStyle.None;
            register_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_name.Location = new Point(145, 312);
            register_name.Margin = new Padding(4);
            register_name.Name = "register_name";
            register_name.Size = new Size(292, 27);
            register_name.TabIndex = 7;
            // 
            // register_closeBtn
            // 
            register_closeBtn.BackColor = Color.FromArgb(0, 74, 173);
            register_closeBtn.Cursor = Cursors.Hand;
            register_closeBtn.Image = Properties.Resources.CloseIcon;
            register_closeBtn.Location = new Point(1074, 15);
            register_closeBtn.Margin = new Padding(4);
            register_closeBtn.Name = "register_closeBtn";
            register_closeBtn.Size = new Size(36, 39);
            register_closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            register_closeBtn.TabIndex = 6;
            register_closeBtn.TabStop = false;
            register_closeBtn.Click += register_closeBtn_Click;
            // 
            // register_username
            // 
            register_username.BorderStyle = BorderStyle.None;
            register_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.Location = new Point(145, 419);
            register_username.Margin = new Padding(4);
            register_username.Name = "register_username";
            register_username.Size = new Size(292, 27);
            register_username.TabIndex = 11;
            // 
            // register_password
            // 
            register_password.BorderStyle = BorderStyle.None;
            register_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(145, 529);
            register_password.Margin = new Padding(4);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(250, 27);
            register_password.TabIndex = 12;
            // 
            // register_loginBtn
            // 
            register_loginBtn.AutoSize = true;
            register_loginBtn.BackColor = Color.Transparent;
            register_loginBtn.Cursor = Cursors.Hand;
            register_loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_loginBtn.ForeColor = SystemColors.ControlText;
            register_loginBtn.Location = new Point(329, 225);
            register_loginBtn.Margin = new Padding(4, 0, 4, 0);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(46, 20);
            register_loginBtn.TabIndex = 13;
            register_loginBtn.Text = "Login";
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // register_showPassword
            // 
            register_showPassword.AutoSize = true;
            register_showPassword.Location = new Point(410, 540);
            register_showPassword.Margin = new Padding(4);
            register_showPassword.Name = "register_showPassword";
            register_showPassword.Size = new Size(18, 17);
            register_showPassword.TabIndex = 14;
            register_showPassword.UseVisualStyleBackColor = true;
            register_showPassword.CheckedChanged += register_showPassword_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(604, 286);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(328, 335);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 750);
            Controls.Add(pictureBox2);
            Controls.Add(register_showPassword);
            Controls.Add(register_loginBtn);
            Controls.Add(register_password);
            Controls.Add(register_username);
            Controls.Add(button1);
            Controls.Add(register_name);
            Controls.Add(register_closeBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)register_closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox register_name;
        private PictureBox register_closeBtn;
        private TextBox register_username;
        private TextBox register_password;
        private Label register_loginBtn;
        private CheckBox register_showPassword;
        private PictureBox pictureBox2;
    }
}