using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentsForm : Form
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.dataSet1.StudentTable);
            LabelClassID.Text = ClassID.ToString();
            LabelClassName.Text = ClassName.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.studentTableBindingSource.EndEdit();
            this.studentTableTableAdapter.Update(dataSet1.StudentTable);
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
