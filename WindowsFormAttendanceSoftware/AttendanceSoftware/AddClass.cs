﻿using System;
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
    public partial class AddClass : Form
    {
        public int UserID { get; set; }
        public AddClass()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClassesTableTableAdapter ada = new DataSet1TableAdapters.ClassesTableTableAdapter();
            ada.AddClass(className_txt.Text, UserID);
            Close();
        }
    }
}
