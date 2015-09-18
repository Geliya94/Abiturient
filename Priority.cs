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
    public partial class Priority : Form
    {
        static public string connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        Generation_Class generation_class = new Generation_Class(connectionstring); 
        public Priority()
        {
            InitializeComponent();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            SqlDataReader read_stud = generation_class.ReadTable("Student");
            SqlDataReader read_spec = generation_class.ReadTable("Specialty");
            //int count = generation_class.Count("Specialty");

            int[] mas = new int[5];

            int i = 0;
            while (read_spec.Read())
            {
                mas[i] = Convert.ToInt32(read_spec.GetValue(0).ToString());
                i++;
            }

            Random rn = new Random();
            int max = 0;
            int min = 0;
            min = mas[0];
            max = mas[0];
            for (int j = 0; j < mas.Length - 1; j++)
            {

                for (int k = j + 1; k < mas.Length; k++)
                {
                    if (mas[k] < min)
                        min = mas[k];
                    if (mas[k] > max)
                        max = mas[k];
                }
            }
            while (read_stud.Read())
            {
                
                int[] masspec = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    masspec[j] = rn.Next(min, max);
                    if (j > 0)
                    {
                        int temp = masspec[j];
                        for (int jj = j - 1; jj >= 0; jj--)
                        {
                            if (temp == masspec[jj])
                            {
                                j--;
                            }
                        }
                    }
                }
                int[] masprior = new int[3];
                for (int j = 0; j < 2; j++)
                {
                    masprior[j] = rn.Next(1, 3);
                    if (j > 0)
                    {
                        int temp = masprior[j];
                        for (int jj = j - 1; jj >= 0; jj--)
                        {
                            if (temp == masprior[jj])
                            {
                                j--;
                            }
                        }
                    }
                }
                masprior[2] = 6 - masprior[0] - masprior[1];
                
            //for(int k=0; k<masspec.Length; k++)
            //{
            //    int sum = 0;
            //  /*  SqlDataReader readsubj = generation_class.IdSubj(masspec[k]);
            //    while (readsubj.Read())
            //    {
            //        SqlDataReader readScore = generation_class.Score(Convert.ToInt32(readsubj.GetValue(0)), Convert.ToInt32(read_stud.GetValue(0)));
            //        while (readScore.Read())
            //        {
            //            sum += Convert.ToInt32(readScore.GetValue(0));
            //        }
            //    }*/
            //  //  sum = generation_class.Sum(masspec[k],Convert.ToInt32(read_stud.GetValue(0)));
                
            //}

            List<List> list_prio = new List<List>();
            for (int k = 0; k < masspec.Length; k++ )
                {
                    list_prio.Add(new List { ID_student = Convert.ToInt32(read_stud.GetValue(0)), ID_specialty = masspec[k], Prio = masprior[k], Sum = rn.Next(150, 260) });
                }

            foreach (var k in list_prio)
            {
                generation_class.Priority("Priority", "ID_student", "ID_specialty", "Prior", "Sum", k.ID_student, k.ID_specialty, k.Prio, k.Sum);
            }
            }

            generation_class.WriterTablePriority("Priority", DGC_priority);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generation_class.Delete("Priority");
            DGC_priority.Rows.Clear();
        }

        private void Priority_Load(object sender, EventArgs e)
        {
            generation_class.WriterTablePriority("Priority", DGC_priority);
        }
    }
}
