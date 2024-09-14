namespace ConstructionApp.Views
{
    partial class VehicleForm
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_lorry = new Button();
            btn_lorryView = new Button();
            btn_lorryAdd = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            btn_cab = new Button();
            btn_cabView = new Button();
            btn_cabAdd = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            btn_jeep = new Button();
            btn_jeepView = new Button();
            btn_jeepAdd = new Button();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            btn_bike = new Button();
            btn_bikeView = new Button();
            btn_bikeAdd = new Button();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1560, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(20, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 37);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Management";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btn_lorry);
            panel2.Controls.Add(btn_lorryView);
            panel2.Controls.Add(btn_lorryAdd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(41, 144);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 336);
            panel2.TabIndex = 1;
            // 
            // btn_lorry
            // 
            btn_lorry.Cursor = Cursors.Hand;
            btn_lorry.Image = Properties.Resources.Link;
            btn_lorry.Location = new Point(604, 35);
            btn_lorry.Margin = new Padding(4, 4, 4, 4);
            btn_lorry.Name = "btn_lorry";
            btn_lorry.Size = new Size(69, 69);
            btn_lorry.TabIndex = 4;
            btn_lorry.UseVisualStyleBackColor = true;
            btn_lorry.Click += btn_lorry_Click;
            // 
            // btn_lorryView
            // 
            btn_lorryView.BackColor = SystemColors.ButtonFace;
            btn_lorryView.Cursor = Cursors.Hand;
            btn_lorryView.Font = new Font("Segoe UI", 12F);
            btn_lorryView.Image = Properties.Resources.View;
            btn_lorryView.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lorryView.Location = new Point(332, 230);
            btn_lorryView.Margin = new Padding(4, 4, 4, 4);
            btn_lorryView.Name = "btn_lorryView";
            btn_lorryView.Padding = new Padding(25, 0, 0, 0);
            btn_lorryView.Size = new Size(159, 62);
            btn_lorryView.TabIndex = 3;
            btn_lorryView.Text = "View";
            btn_lorryView.UseVisualStyleBackColor = false;
            // 
            // btn_lorryAdd
            // 
            btn_lorryAdd.BackColor = SystemColors.ActiveCaption;
            btn_lorryAdd.Cursor = Cursors.Hand;
            btn_lorryAdd.Font = new Font("Segoe UI", 12F);
            btn_lorryAdd.Image = Properties.Resources.add;
            btn_lorryAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lorryAdd.Location = new Point(514, 230);
            btn_lorryAdd.Margin = new Padding(4, 4, 4, 4);
            btn_lorryAdd.Name = "btn_lorryAdd";
            btn_lorryAdd.Padding = new Padding(31, 0, 0, 0);
            btn_lorryAdd.Size = new Size(159, 62);
            btn_lorryAdd.TabIndex = 2;
            btn_lorryAdd.Text = "Add";
            btn_lorryAdd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(285, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 40);
            label2.TabIndex = 1;
            label2.Text = "LB - 7979";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Tipper;
            pictureBox1.Location = new Point(40, 60);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(btn_cab);
            panel6.Controls.Add(btn_cabView);
            panel6.Controls.Add(btn_cabAdd);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(pictureBox2);
            panel6.Location = new Point(804, 144);
            panel6.Margin = new Padding(4, 4, 4, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(712, 336);
            panel6.TabIndex = 5;
            // 
            // btn_cab
            // 
            btn_cab.Cursor = Cursors.Hand;
            btn_cab.Image = Properties.Resources.Link;
            btn_cab.Location = new Point(604, 35);
            btn_cab.Margin = new Padding(4, 4, 4, 4);
            btn_cab.Name = "btn_cab";
            btn_cab.Size = new Size(69, 69);
            btn_cab.TabIndex = 4;
            btn_cab.UseVisualStyleBackColor = true;
            btn_cab.Click += btn_cab_Click;
            // 
            // btn_cabView
            // 
            btn_cabView.BackColor = SystemColors.ButtonFace;
            btn_cabView.Cursor = Cursors.Hand;
            btn_cabView.Font = new Font("Segoe UI", 12F);
            btn_cabView.Image = Properties.Resources.View;
            btn_cabView.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cabView.Location = new Point(332, 230);
            btn_cabView.Margin = new Padding(4, 4, 4, 4);
            btn_cabView.Name = "btn_cabView";
            btn_cabView.Padding = new Padding(25, 0, 0, 0);
            btn_cabView.Size = new Size(159, 62);
            btn_cabView.TabIndex = 3;
            btn_cabView.Text = "View";
            btn_cabView.UseVisualStyleBackColor = false;
            // 
            // btn_cabAdd
            // 
            btn_cabAdd.BackColor = SystemColors.ActiveCaption;
            btn_cabAdd.Cursor = Cursors.Hand;
            btn_cabAdd.Font = new Font("Segoe UI", 12F);
            btn_cabAdd.Image = Properties.Resources.add;
            btn_cabAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cabAdd.Location = new Point(514, 230);
            btn_cabAdd.Margin = new Padding(4, 4, 4, 4);
            btn_cabAdd.Name = "btn_cabAdd";
            btn_cabAdd.Padding = new Padding(31, 0, 0, 0);
            btn_cabAdd.Size = new Size(159, 62);
            btn_cabAdd.TabIndex = 2;
            btn_cabAdd.Text = "Add";
            btn_cabAdd.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(285, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 40);
            label3.TabIndex = 1;
            label3.Text = "DAH - 1931";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Cab1;
            pictureBox2.Location = new Point(40, 60);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(btn_jeep);
            panel7.Controls.Add(btn_jeepView);
            panel7.Controls.Add(btn_jeepAdd);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(41, 529);
            panel7.Margin = new Padding(4, 4, 4, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(712, 336);
            panel7.TabIndex = 5;
            // 
            // btn_jeep
            // 
            btn_jeep.Cursor = Cursors.Hand;
            btn_jeep.Image = Properties.Resources.Link;
            btn_jeep.Location = new Point(604, 35);
            btn_jeep.Margin = new Padding(4, 4, 4, 4);
            btn_jeep.Name = "btn_jeep";
            btn_jeep.Size = new Size(69, 69);
            btn_jeep.TabIndex = 4;
            btn_jeep.UseVisualStyleBackColor = true;
            btn_jeep.Click += btn_jeep_Click;
            // 
            // btn_jeepView
            // 
            btn_jeepView.BackColor = SystemColors.ButtonFace;
            btn_jeepView.Cursor = Cursors.Hand;
            btn_jeepView.Font = new Font("Segoe UI", 12F);
            btn_jeepView.Image = Properties.Resources.View;
            btn_jeepView.ImageAlign = ContentAlignment.MiddleLeft;
            btn_jeepView.Location = new Point(332, 230);
            btn_jeepView.Margin = new Padding(4, 4, 4, 4);
            btn_jeepView.Name = "btn_jeepView";
            btn_jeepView.Padding = new Padding(25, 0, 0, 0);
            btn_jeepView.Size = new Size(159, 62);
            btn_jeepView.TabIndex = 3;
            btn_jeepView.Text = "View";
            btn_jeepView.UseVisualStyleBackColor = false;
            // 
            // btn_jeepAdd
            // 
            btn_jeepAdd.BackColor = SystemColors.ActiveCaption;
            btn_jeepAdd.Cursor = Cursors.Hand;
            btn_jeepAdd.Font = new Font("Segoe UI", 12F);
            btn_jeepAdd.Image = Properties.Resources.add;
            btn_jeepAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_jeepAdd.Location = new Point(514, 230);
            btn_jeepAdd.Margin = new Padding(4, 4, 4, 4);
            btn_jeepAdd.Name = "btn_jeepAdd";
            btn_jeepAdd.Padding = new Padding(31, 0, 0, 0);
            btn_jeepAdd.Size = new Size(159, 62);
            btn_jeepAdd.TabIndex = 2;
            btn_jeepAdd.Text = "Add";
            btn_jeepAdd.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(285, 48);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 40);
            label4.TabIndex = 1;
            label4.Text = "KQ - 9995";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Jeep1;
            pictureBox3.Location = new Point(40, 60);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 200);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Control;
            panel8.Controls.Add(btn_bike);
            panel8.Controls.Add(btn_bikeView);
            panel8.Controls.Add(btn_bikeAdd);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(pictureBox4);
            panel8.Location = new Point(804, 529);
            panel8.Margin = new Padding(4, 4, 4, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(712, 336);
            panel8.TabIndex = 5;
            // 
            // btn_bike
            // 
            btn_bike.Cursor = Cursors.Hand;
            btn_bike.Image = Properties.Resources.Link;
            btn_bike.Location = new Point(604, 35);
            btn_bike.Margin = new Padding(4, 4, 4, 4);
            btn_bike.Name = "btn_bike";
            btn_bike.Size = new Size(69, 69);
            btn_bike.TabIndex = 4;
            btn_bike.UseVisualStyleBackColor = true;
            btn_bike.Click += btn_bike_Click;
            // 
            // btn_bikeView
            // 
            btn_bikeView.BackColor = SystemColors.ButtonFace;
            btn_bikeView.Cursor = Cursors.Hand;
            btn_bikeView.Font = new Font("Segoe UI", 12F);
            btn_bikeView.Image = Properties.Resources.View;
            btn_bikeView.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bikeView.Location = new Point(332, 230);
            btn_bikeView.Margin = new Padding(4, 4, 4, 4);
            btn_bikeView.Name = "btn_bikeView";
            btn_bikeView.Padding = new Padding(25, 0, 0, 0);
            btn_bikeView.Size = new Size(159, 62);
            btn_bikeView.TabIndex = 3;
            btn_bikeView.Text = "View";
            btn_bikeView.UseVisualStyleBackColor = false;
            // 
            // btn_bikeAdd
            // 
            btn_bikeAdd.BackColor = SystemColors.ActiveCaption;
            btn_bikeAdd.Cursor = Cursors.Hand;
            btn_bikeAdd.Font = new Font("Segoe UI", 12F);
            btn_bikeAdd.Image = Properties.Resources.add;
            btn_bikeAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bikeAdd.Location = new Point(514, 230);
            btn_bikeAdd.Margin = new Padding(4, 4, 4, 4);
            btn_bikeAdd.Name = "btn_bikeAdd";
            btn_bikeAdd.Padding = new Padding(31, 0, 0, 0);
            btn_bikeAdd.Size = new Size(159, 62);
            btn_bikeAdd.TabIndex = 2;
            btn_bikeAdd.Text = "Add";
            btn_bikeAdd.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(285, 48);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(171, 40);
            label5.TabIndex = 1;
            label5.Text = "WS - 6751";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Motorcycle;
            pictureBox4.Location = new Point(40, 60);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 200);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // VehicleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "VehicleForm";
            Size = new Size(1560, 1066);
            Load += VehicleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Button btn_lorryAdd;
        private Label label2;
        private Button btn_lorryView;
        private Button btn_lorry;
        private Panel panel6;
        private Button btn_cab;
        private Button btn_cabView;
        private Button btn_cabAdd;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Button btn_jeep;
        private Button btn_jeepView;
        private Button btn_jeepAdd;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel panel8;
        private Button btn_bike;
        private Button btn_bikeView;
        private Button btn_bikeAdd;
        private Label label5;
        private PictureBox pictureBox4;
    }
}
