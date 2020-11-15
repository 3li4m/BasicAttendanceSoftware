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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == textBoxPassConfirm.Text) 
            {
                DataSet1TableAdapters.usersTableAdapter ada = new DataSet1TableAdapters.usersTableAdapter();
                ada.InsertQueryNewUser(textBoxUserName.Text, textBoxPass.Text);
                MessageBox.Show("Registration Complete!");
                Close();
            }
            else
            {
                MessageBox.Show("Passwords Did Not Match!");
            }


        }
    }
}
