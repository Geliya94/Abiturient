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
    public partial class Specialty : Form
    {
        static public string connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        Generation_Class generation_class = new Generation_Class(connectionstring);
        public Specialty()
        {
            InitializeComponent();
        }

        private void Specialty_Load(object sender, EventArgs e)
        {
            string nameTable = "Specialty";
            generation_class.WriterTableStaudent1(nameTable, DGV_specialty);
        }

        private void BTN_generation_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TB_abit.Text);
            string nameTable = "Specialty";
            string parametr1 = "Specialty";
            string parametr2 = "Amount";
            string name = "Специальность";
            generation_class.GenAdd1(n, nameTable, parametr1,parametr2, DGV_specialty, name);
            generation_class.WriterTableStaudent1(nameTable, DGV_specialty);
        }
    }
}
