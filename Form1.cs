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
    public partial class Form1 : Form
    {
        static public string connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_abiturient_Click(object sender, EventArgs e)
        {
            Abiturient form_abiturient = new Abiturient();
            form_abiturient.Show();
        }

        private void BTN_subject_Click(object sender, EventArgs e)
        {
            Subject form_subject = new Subject();
            form_subject.Show();
        }

        private void BTN_specialty_Click(object sender, EventArgs e)
        {
            Specialty form_specialty = new Specialty();
            form_specialty.Show();
        }

        private void BTN_specsubj_Click(object sender, EventArgs e)
        {
            Spec_Subj spec_subj = new Spec_Subj();
            spec_subj.Show();
        }

        private void BTN_abitsubj_Click(object sender, EventArgs e)
        {
            Stud_Subj form_studsubj = new Stud_Subj();
            form_studsubj.Show();
        }

        private void BTN_priority_Click(object sender, EventArgs e)
        {
            Priority form_prior = new Priority();
            form_prior.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Generation_Class generation_class = new Generation_Class(connectionstring);
            SqlDataReader read_spec = generation_class.ReadTable("Specialty");

            SqlDataReader read_spiski = generation_class.ReadTable("Priority");
            List<List> list_spisok = new List<List>();
            while (read_spiski.Read())
            {
                list_spisok.Add(new List { ID_student = Convert.ToInt32(read_spiski.GetValue(1)), ID_specialty = Convert.ToInt32(read_spiski.GetValue(2)), Prio = Convert.ToInt32(read_spiski.GetValue(3)), Sum = Convert.ToInt32(read_spiski.GetValue(4)) });                
            }

            List<ListSpec> listSpec = new List<ListSpec>();
            while (read_spec.Read())
            {
                listSpec.Add(new ListSpec { ID = Convert.ToInt32(read_spec.GetValue(0)), Specialty = (read_spec.GetValue(1)).ToString(), Amount = Convert.ToInt32(read_spec.GetValue(2)) }); 
            }

            int i = 0;
            List<ListFirstSpec> listFirstSpec = new List<ListFirstSpec>();
          foreach(var k in listSpec)
            {
              DataGridView dgv = new DataGridView();
              DataGridView dgv1 = new DataGridView();
                            dgv.Name = "DGV" + i.ToString();
                            dgv.Width = 500;
                            dgv.Height = 500;
                            dgv.Left = 0;
                            dgv.Top = 0;
                            dgv.Columns.Add("123", "Номер_студента");
                            dgv.Columns.Add("123", "Приоритет");
                            dgv.Columns.Add("123", "Сумма баллов");
                            tabControl1.TabPages[i].Controls.Add(dgv);
                            foreach (var j in list_spisok)
                            {
                                if (j.ID_specialty == k.ID)
                                {
                                    
                                    //dgv.Rows.Add(j.ID_student, j.Prio, j.Sum);
                                }

                            }
                        i++;  
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SubjectReadClass readTableSubj = new SubjectReadClass();
            AbiturientReadClass readTableAbit = new AbiturientReadClass();
            SpecialtyReadClass readTableSpec = new SpecialtyReadClass();
            readTableSubj.ReadTableSubj();
            readTableSpec.ReadTableSpec();
            readTableAbit.ReadTableAbit();
          
        }
    }
}
