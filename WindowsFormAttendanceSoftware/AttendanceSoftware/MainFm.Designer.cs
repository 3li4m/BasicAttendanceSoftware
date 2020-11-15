
namespace WindowsFormsApp1
{
    partial class MainFm
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
            this.components = new System.ComponentModel.Container();
            this.Tabheader = new MetroFramework.Controls.MetroTabControl();
            this.Attendance_Tab = new MetroFramework.Controls.MetroTabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLblUsr = new System.Windows.Forms.ToolStripStatusLabel();
            this.GetDateBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceRecTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.classesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reports_Tab = new MetroFramework.Controls.MetroTabPage();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Student_columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Present_columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Absense_columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lates_columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Excused_columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classesTableTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.ClassesTableTableAdapter();
            this.attendanceRecTableTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.AttendanceRecTableTableAdapter();
            this.RegisterUserBtn = new System.Windows.Forms.Button();
            this.Tabheader.SuspendLayout();
            this.Attendance_Tab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesTableBindingSource)).BeginInit();
            this.Reports_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabheader
            // 
            this.Tabheader.AccessibleName = "";
            this.Tabheader.Controls.Add(this.Attendance_Tab);
            this.Tabheader.Controls.Add(this.Reports_Tab);
            this.Tabheader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabheader.Location = new System.Drawing.Point(20, 60);
            this.Tabheader.Name = "Tabheader";
            this.Tabheader.SelectedIndex = 0;
            this.Tabheader.Size = new System.Drawing.Size(771, 515);
            this.Tabheader.TabIndex = 0;
            // 
            // Attendance_Tab
            // 
            this.Attendance_Tab.Controls.Add(this.RegisterUserBtn);
            this.Attendance_Tab.Controls.Add(this.statusStrip1);
            this.Attendance_Tab.Controls.Add(this.GetDateBtn);
            this.Attendance_Tab.Controls.Add(this.metroButton2);
            this.Attendance_Tab.Controls.Add(this.metroButton4);
            this.Attendance_Tab.Controls.Add(this.metroButton3);
            this.Attendance_Tab.Controls.Add(this.metroButton1);
            this.Attendance_Tab.Controls.Add(this.dataGridView1);
            this.Attendance_Tab.Controls.Add(this.metroLabel2);
            this.Attendance_Tab.Controls.Add(this.metroLabel3);
            this.Attendance_Tab.Controls.Add(this.dateTimePicker1);
            this.Attendance_Tab.Controls.Add(this.metroComboBox1);
            this.Attendance_Tab.HorizontalScrollbarBarColor = true;
            this.Attendance_Tab.Location = new System.Drawing.Point(4, 35);
            this.Attendance_Tab.Name = "Attendance_Tab";
            this.Attendance_Tab.Size = new System.Drawing.Size(763, 476);
            this.Attendance_Tab.TabIndex = 0;
            this.Attendance_Tab.Text = "Attendance";
            this.Attendance_Tab.VerticalScrollbarBarColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statLblUsr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(763, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel1.Text = "User";
            // 
            // statLblUsr
            // 
            this.statLblUsr.Name = "statLblUsr";
            this.statLblUsr.Size = new System.Drawing.Size(12, 17);
            this.statLblUsr.Text = "-";
            // 
            // GetDateBtn
            // 
            this.GetDateBtn.Location = new System.Drawing.Point(405, 35);
            this.GetDateBtn.Name = "GetDateBtn";
            this.GetDateBtn.Size = new System.Drawing.Size(75, 20);
            this.GetDateBtn.TabIndex = 6;
            this.GetDateBtn.Text = "Get Date";
            this.GetDateBtn.Click += new System.EventHandler(this.GetDateBtn_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(405, 120);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Clear";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(651, 57);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(111, 23);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Add Students";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(651, 28);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(111, 23);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Add Class";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(405, 91);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Save";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceRecTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 346);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // attendanceRecTableBindingSource
            // 
            this.attendanceRecTableBindingSource.DataMember = "AttendanceRecTable";
            this.attendanceRecTableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Select Class";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(251, 13);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Select Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.classesTableBindingSource;
            this.metroComboBox1.DisplayMember = "ClassName";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(3, 35);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(207, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.ValueMember = "ClassID";
            // 
            // classesTableBindingSource
            // 
            this.classesTableBindingSource.DataMember = "ClassesTable";
            this.classesTableBindingSource.DataSource = this.dataSet1;
            // 
            // Reports_Tab
            // 
            this.Reports_Tab.Controls.Add(this.metroButton5);
            this.Reports_Tab.Controls.Add(this.metroLabel1);
            this.Reports_Tab.Controls.Add(this.metroLabel4);
            this.Reports_Tab.Controls.Add(this.dateTimePicker2);
            this.Reports_Tab.Controls.Add(this.metroComboBox2);
            this.Reports_Tab.Controls.Add(this.listView1);
            this.Reports_Tab.HorizontalScrollbarBarColor = true;
            this.Reports_Tab.Location = new System.Drawing.Point(4, 35);
            this.Reports_Tab.Name = "Reports_Tab";
            this.Reports_Tab.Size = new System.Drawing.Size(763, 476);
            this.Reports_Tab.TabIndex = 1;
            this.Reports_Tab.Text = "Reports";
            this.Reports_Tab.VerticalScrollbarBarColor = true;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(428, 27);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 20);
            this.metroButton5.TabIndex = 17;
            this.metroButton5.Text = "Get Date";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Select Class";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(274, 5);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Select Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(274, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.DataSource = this.classesTableBindingSource;
            this.metroComboBox2.DisplayMember = "ClassName";
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(26, 27);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(207, 29);
            this.metroComboBox2.TabIndex = 13;
            this.metroComboBox2.ValueMember = "ClassID";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Student_columnHeader1,
            this.Present_columnHeader2,
            this.Absense_columnHeader3,
            this.Lates_columnHeader4,
            this.Excused_columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(701, 294);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Student_columnHeader1
            // 
            this.Student_columnHeader1.Text = "Student";
            this.Student_columnHeader1.Width = 102;
            // 
            // Present_columnHeader2
            // 
            this.Present_columnHeader2.Text = "Presence";
            this.Present_columnHeader2.Width = 108;
            // 
            // Absense_columnHeader3
            // 
            this.Absense_columnHeader3.Text = "Absense";
            this.Absense_columnHeader3.Width = 94;
            // 
            // Lates_columnHeader4
            // 
            this.Lates_columnHeader4.Text = "Lates";
            this.Lates_columnHeader4.Width = 106;
            // 
            // Excused_columnHeader5
            // 
            this.Excused_columnHeader5.Text = "Excused";
            this.Excused_columnHeader5.Width = 110;
            // 
            // classesTableTableAdapter
            // 
            this.classesTableTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceRecTableTableAdapter
            // 
            this.attendanceRecTableTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterUserBtn
            // 
            this.RegisterUserBtn.Location = new System.Drawing.Point(651, 389);
            this.RegisterUserBtn.Name = "RegisterUserBtn";
            this.RegisterUserBtn.Size = new System.Drawing.Size(111, 23);
            this.RegisterUserBtn.TabIndex = 8;
            this.RegisterUserBtn.Text = "Register User";
            this.RegisterUserBtn.UseVisualStyleBackColor = true;
            this.RegisterUserBtn.Click += new System.EventHandler(this.RegisterUserBtn_Click);
            // 
            // MainFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 595);
            this.Controls.Add(this.Tabheader);
            this.Name = "MainFm";
            this.Text = "Attendence";
            this.Activated += new System.EventHandler(this.main_Activated);
            this.Load += new System.EventHandler(this.MainFm_Load);
            this.Tabheader.ResumeLayout(false);
            this.Attendance_Tab.ResumeLayout(false);
            this.Attendance_Tab.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesTableBindingSource)).EndInit();
            this.Reports_Tab.ResumeLayout(false);
            this.Reports_Tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tabheader;
        private MetroFramework.Controls.MetroTabPage Attendance_Tab;
        private MetroFramework.Controls.MetroTabPage Reports_Tab;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statLblUsr;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource classesTableBindingSource;
        private DataSet1TableAdapters.ClassesTableTableAdapter classesTableTableAdapter;
        private MetroFramework.Controls.MetroButton GetDateBtn;
        private System.Windows.Forms.BindingSource attendanceRecTableBindingSource;
        private DataSet1TableAdapters.AttendanceRecTableTableAdapter attendanceRecTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Student_columnHeader1;
        private System.Windows.Forms.ColumnHeader Present_columnHeader2;
        private System.Windows.Forms.ColumnHeader Absense_columnHeader3;
        private System.Windows.Forms.ColumnHeader Lates_columnHeader4;
        private System.Windows.Forms.ColumnHeader Excused_columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button RegisterUserBtn;
    }
}