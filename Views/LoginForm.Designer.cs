namespace ConstructionApp.Views
{
    partial class LoginForm
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
            login = new PictureBox();
            pictureBox2 = new PictureBox();
            login_username = new TextBox();
            login_password = new TextBox();
            login_registerBtn = new Label();
            login_btn = new Button();
            login_showPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = Color.White;
            login.BorderStyle = BorderStyle.FixedSingle;
            login.Dock = DockStyle.Fill;
            login.Image = Properties.Resources.LoginPage1;
            login.Location = new Point(0, 0);
            login.Margin = new Padding(4, 4, 4, 4);
            login.Name = "login";
            login.Size = new Size(1125, 750);
            login.SizeMode = PictureBoxSizeMode.StretchImage;
            login.TabIndex = 0;
            login.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 74, 173);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.CloseIcon;
            pictureBox2.Location = new Point(1074, 15);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.None;
            login_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(409, 346);
            login_username.Margin = new Padding(4, 4, 4, 4);
            login_username.Name = "login_username";
            login_username.Size = new Size(318, 27);
            login_username.TabIndex = 2;
            login_username.TextChanged += login_username_TextChanged;
            // 
            // login_password
            // 
            login_password.BorderStyle = BorderStyle.None;
            login_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(409, 462);
            login_password.Margin = new Padding(4, 4, 4, 4);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(269, 27);
            login_password.TabIndex = 3;
            // 
            // login_registerBtn
            // 
            login_registerBtn.AutoSize = true;
            login_registerBtn.BackColor = Color.Transparent;
            login_registerBtn.Cursor = Cursors.Hand;
            login_registerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_registerBtn.ForeColor = SystemColors.ControlText;
            login_registerBtn.Location = new Point(599, 544);
            login_registerBtn.Margin = new Padding(4, 0, 4, 0);
            login_registerBtn.Name = "login_registerBtn";
            login_registerBtn.Size = new Size(63, 20);
            login_registerBtn.TabIndex = 4;
            login_registerBtn.Text = "Register";
            login_registerBtn.Click += login_registerBtn_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(0, 74, 173);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 89, 171);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 89, 171);
            login_btn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(451, 592);
            login_btn.Margin = new Padding(4, 4, 4, 4);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(226, 60);
            login_btn.TabIndex = 5;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += button1_Click;
            // 
            // login_showPassword
            // 
            login_showPassword.AutoSize = true;
            login_showPassword.Location = new Point(702, 471);
            login_showPassword.Margin = new Padding(4, 4, 4, 4);
            login_showPassword.Name = "login_showPassword";
            login_showPassword.Size = new Size(18, 17);
            login_showPassword.TabIndex = 6;
            login_showPassword.UseVisualStyleBackColor = true;
            login_showPassword.CheckedChanged += login_showPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 750);
            Controls.Add(login_showPassword);
            Controls.Add(login_btn);
            Controls.Add(login_registerBtn);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(pictureBox2);
            Controls.Add(login);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)login).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox login;
        private PictureBox pictureBox2;
        private TextBox login_username;
        private TextBox login_password;
        private Label login_registerBtn;
        private Button login_btn;
        private CheckBox login_showPassword;
    }
}