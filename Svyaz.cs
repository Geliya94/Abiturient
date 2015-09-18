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
    public partial class Svyaz : Form
    {
        public Svyaz()
        {
            InitializeComponent();
        }
        static public string connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        Generation_Class generation_class = new Generation_Class(connectionstring);

        private void button1_Click(object sender, EventArgs e)
        {
            //    Random rn = new Random();
            //    int[] masprior = new int[3];
            //    for (int j = 0; j < 2; j++)
            //    {
            //        masprior[j] = rn.Next(1, 3);
            //        if (j > 0)
            //        {
            //            int temp = masprior[j];
            //            for (int jj = j - 1; jj >= 0; jj--)
            //            {
            //                if (temp == masprior[jj])
            //                {
            //                    j--;
            //                }
            //            }
            //        }
            //    }
            //    masprior[2] = 6 - masprior[0] - masprior[1];
            //   SqlDataReader readpr= generation_class.WriterTable("Priority");



            //    List<List> list_prio = new List<List>();
            //    while (readpr.Read())
            //   {
            //       list_prio.Add(new List { ID = Convert.ToInt32(readpr.GetValue(0)), ID_student = Convert.ToInt32(readpr.GetValue(1)), ID_specialty = Convert.ToInt32(readpr.GetValue(2)) });

            //   }

            //    int i = 0;
            //    foreach (var k in list_prio)
            //    {
            //      //  int sum = generation_class.Sum(k.ID_specialty, k.ID_student);
            //        generation_class.Stud_Sub("Svyaz", "ID_priority", "Npriority", "Sum", k.ID, masprior[i], rn.Next(150,260));
            //        i++;
            //        if (i == 3)
            //            i = 0;
            //    }
            //    generation_class.WriterTableStudentSubj("Svyaz", dataGridView1);
            //}
        }
    }
}
