namespace ConstructionApp.Views.EmployeeSection
{
    partial class Overview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            sitesearchTbox = new TextBox();
            panel2 = new Panel();
            dateresetBtn = new Button();
            dateenterBtn = new Button();
            subsearchTbox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            clearBtn = new Button();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = Color.Transparent;
            chart1.BorderlineColor = Color.Transparent;
            chartArea2.BackColor = Color.Transparent;
            chartArea2.BackSecondaryColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(-17, 125);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            series2.ShadowColor = Color.Transparent;
            series2.SmartLabelStyle.Enabled = false;
            chart1.Series.Add(series2);
            chart1.Size = new Size(375, 375);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(750, 542);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(chart1);
            panel1.Location = new Point(827, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 732);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(186, 648);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 7;
            label5.Text = "Arrears Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(186, 598);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 6;
            label4.Text = "Paid Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(186, 552);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 5;
            label3.Text = "Total Salary";
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.FlatAppearance.BorderColor = Color.Orange;
            button3.FlatAppearance.MouseDownBackColor = Color.Orange;
            button3.FlatAppearance.MouseOverBackColor = Color.Orange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(118, 642);
            button3.Name = "button3";
            button3.Size = new Size(47, 29);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(118, 546);
            button2.Name = "button2";
            button2.Size = new Size(47, 29);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(118, 592);
            button1.Name = "button1";
            button1.Size = new Size(47, 29);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 63);
            label2.Name = "label2";
            label2.Size = new Size(230, 27);
            label2.TabIndex = 1;
            label2.Text = "Total Payroll of Month";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 23);
            label1.Name = "label1";
            label1.Size = new Size(275, 37);
            label1.TabIndex = 4;
            label1.Text = "Overview of Payroll";
            // 
            // sitesearchTbox
            // 
            sitesearchTbox.BackColor = SystemColors.ControlLight;
            sitesearchTbox.BorderStyle = BorderStyle.FixedSingle;
            sitesearchTbox.Font = new Font("Segoe UI", 10F);
            sitesearchTbox.Location = new Point(18, 682);
            sitesearchTbox.Multiline = true;
            sitesearchTbox.Name = "sitesearchTbox";
            sitesearchTbox.Size = new Size(260, 35);
            sitesearchTbox.TabIndex = 5;
            sitesearchTbox.TextAlign = HorizontalAlignment.Right;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(dateresetBtn);
            panel2.Controls.Add(dateenterBtn);
            panel2.Controls.Add(subsearchTbox);
            panel2.Controls.Add(sitesearchTbox);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(clearBtn);
            panel2.Controls.Add(searchBtn);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(19, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 732);
            panel2.TabIndex = 8;
            // 
            // dateresetBtn
            // 
            dateresetBtn.BackColor = Color.White;
            dateresetBtn.Cursor = Cursors.Hand;
            dateresetBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateresetBtn.Location = new Point(669, 83);
            dateresetBtn.Name = "dateresetBtn";
            dateresetBtn.Size = new Size(100, 40);
            dateresetBtn.TabIndex = 13;
            dateresetBtn.Text = "Reset";
            dateresetBtn.UseVisualStyleBackColor = false;
            dateresetBtn.Click += dateresetBtn_Click;
            // 
            // dateenterBtn
            // 
            dateenterBtn.BackColor = Color.FromArgb(0, 74, 173);
            dateenterBtn.Cursor = Cursors.Hand;
            dateenterBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateenterBtn.ForeColor = SystemColors.Control;
            dateenterBtn.Location = new Point(558, 83);
            dateenterBtn.Name = "dateenterBtn";
            dateenterBtn.Size = new Size(100, 40);
            dateenterBtn.TabIndex = 12;
            dateenterBtn.Text = "Enter";
            dateenterBtn.UseVisualStyleBackColor = false;
            dateenterBtn.Click += dateenterBtn_Click;
            // 
            // subsearchTbox
            // 
            subsearchTbox.BackColor = SystemColors.ControlLight;
            subsearchTbox.BorderStyle = BorderStyle.FixedSingle;
            subsearchTbox.Font = new Font("Segoe UI", 10F);
            subsearchTbox.Location = new Point(292, 682);
            subsearchTbox.Multiline = true;
            subsearchTbox.Name = "subsearchTbox";
            subsearchTbox.Size = new Size(260, 35);
            subsearchTbox.TabIndex = 11;
            subsearchTbox.TextAlign = HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlLight;
            dateTimePicker1.Location = new Point(302, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.White;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(669, 679);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(100, 40);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(0, 74, 173);
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.ForeColor = SystemColors.Control;
            searchBtn.Location = new Point(558, 679);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(100, 40);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Overview";
            Size = new Size(1248, 770);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox sitesearchTbox;
        private Panel panel2;
        private Button searchBtn;
        private Button clearBtn;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox subsearchTbox;
        private Button dateresetBtn;
        private Button dateenterBtn;
    }
}
