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
    public partial class Abiturient : Form
    {
        static public string connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        Generation_Class generation_class = new Generation_Class(connectionstring);
        public Abiturient()
        {
            InitializeComponent();
        }

        private void BTN_generation_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TB_abit.Text);
            string nameTable = "Student";
            string parametr = "FIO";
            string name = "Абитуриент";
            generation_class.GenAdd(n, nameTable, parametr, DGV_abiturient, name);
            generation_class.WriterTableStaudent(nameTable, DGV_abiturient);
        }   

        private void Abiturient_Load(object sender, EventArgs e)
        {
            string nameTable = "Student";
            generation_class.WriterTableStaudent(nameTable, DGV_abiturient);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generation_class.Delete("Student");
            DGV_abiturient.Rows.Clear();

        }
    }
}
