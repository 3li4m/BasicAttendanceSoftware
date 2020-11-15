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
    public partial class LoginFm : Form
    {
        public bool loginFlag { get; set; }
        public int UserID { get; set; }

        public LoginFm()
        {
            InitializeComponent();
            loginFlag = false;
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.usersTableAdapter userAda = new DataSet1TableAdapters.usersTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPass(metroTextBoxUser.Text, metroTextBoxPassword.Text);

            if (dt.Rows.Count <= 0)
            {
                //failed login
                MessageBox.Show("Login Unsuccessful");
                loginFlag = false;
            }
            else {
                //valid login
                MessageBox.Show("Login Successful");
                UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
                loginFlag = true;

                this.Hide();
            }
        }

    }
}
