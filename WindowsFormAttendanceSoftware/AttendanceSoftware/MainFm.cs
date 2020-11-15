using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet1TableAdapters;

namespace WindowsFormsApp1
{
    public partial class MainFm : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int UserID { get; set; }

        public MainFm()
        {
            InitializeComponent();

            loggedIn = 0;
            
        }

        private void main_Activated(object sender, EventArgs e)
        {

            if (loggedIn == 0)
            {
                this.Hide();
                LoginFm loginFm = new LoginFm();
                loginFm.ShowDialog();
                if (loginFm.loginFlag == true)
                {
                    this.Show();
                    UserID = loginFm.UserID;
                    statLblUsr.Text = UserID.ToString();
                    loggedIn = 1;


                    // we only want to displayer the items only when the user is logged in
                    // TODO: This line of code loads data into the 'dataSet1.ClassesTable' table. You can move, or remove it, as needed.
                    this.classesTableTableAdapter.Fill(this.dataSet1.ClassesTable);
                    classesTableBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";
                }
                else
                {
                    Application.Exit();
                }
            }
  
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            addClass.UserID = this.UserID;
            addClass.ShowDialog();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            StudentsForm students = new StudentsForm();
            // combobox holding the class names 
            students.ClassID = (int)metroComboBox1.SelectedValue;
            students.ClassName = metroComboBox1.Text;
            students.ShowDialog();
        }

        private void MainFm_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetDateBtn_Click(object sender, EventArgs e)
        {
            //check if the records exist if yes load them for editing if not create each record for each student
            // and load for edit
            AttendanceRecTableTableAdapter ada = new AttendanceRecTableTableAdapter();
            DataTable dt = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);

            if (dt.Rows.Count > 0)
            {
                // we have records we can edit
                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }
            else
            {
                // create record for each student here 
                // get class students list
                StudentTableTableAdapter student_adaptor = new StudentTableTableAdapter();

                DataTable dt_students = student_adaptor.GetDataByClassID((int)metroComboBox1.SelectedValue);


                foreach (DataRow row in dt_students.Rows) 
                {
                    // insert new rec for student
                    ada.InsertQuery((int)row[0], (int)metroComboBox1.SelectedValue, dateTimePicker1.Text, "", row[1].ToString(), metroComboBox1.Text);
                    
                }

                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }

            // TODO: This line of code loads data into the 'dataSet1.AttendanceRecTable' table. You can move, or remove it, as needed.
            this.attendanceRecTableTableAdapter.Fill(this.dataSet1.AttendanceRecTable);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AttendanceRecTableTableAdapter ada = new AttendanceRecTableTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    // update status
                    ada.UpdateQueryStatus(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                }

            }
            DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AttendanceRecTableTableAdapter ada = new AttendanceRecTableTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    // update status
                    ada.UpdateQueryStatus("", row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                }

            }
            DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            // get students of this selection 
            StudentTableTableAdapter student_adaptor = new StudentTableTableAdapter();
            DataTable dt_students = student_adaptor.GetDataByClassID((int)metroComboBox2.SelectedValue);

            AttendanceRecTableTableAdapter ada = new AttendanceRecTableTableAdapter();
            int presence = 0;
            int absense = 0;
            int late = 0;
            int excused = 0;


            // loop through students and get values 
            foreach (DataRow row in dt_students.Rows) 
            {
                presence = ada.ScalarQuery(dateTimePicker2.Value.Month, row[1].ToString(), "present").Value;
                absense = ada.ScalarQuery(dateTimePicker2.Value.Month, row[1].ToString(), "absent").Value;
                late = ada.ScalarQuery(dateTimePicker2.Value.Month, row[1].ToString(), "late").Value;
                excused = ada.ScalarQuery(dateTimePicker2.Value.Month, row[1].ToString(), "excused").Value;

                // add to list view 
                ListViewItem litem = new ListViewItem();

                litem.Text = row[1].ToString();
                litem.SubItems.Add(presence.ToString());
                litem.SubItems.Add(absense.ToString());
                litem.SubItems.Add(late.ToString());
                litem.SubItems.Add(excused.ToString());

                listView1.Items.Add(litem);

            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RegisterUserBtn_Click(object sender, EventArgs e)
        {
            Register reFm = new Register();
            reFm.ShowDialog();
        }
    }
}
