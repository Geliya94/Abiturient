using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Abiturient
{
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }
        static public string connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        Generation_Class generation_class = new Generation_Class(connectionstring);
      
        private void BTN_generation_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TB_abit.Text);
            string nameTable = "Subject";
            string parametr = "Subject";
            string name = "Предмет";
            generation_class.GenAdd(n, nameTable, parametr, DGV_subject, name);
            generation_class.WriterTableStaudent(nameTable, DGV_subject);
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            string nameTable = "Subject";
            generation_class.WriterTableStaudent(nameTable, DGV_subject);
        }

    }
}
