using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Abiturient
{
    class ReadTableListClass
    {
        static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        static Generation_Class generation = new Generation_Class(connectionString);
        List<Abiturient> listAbit = new List<Abiturient>();
        List<Specialty> listSpec = new List<Specialty>();
        List<Subject> listSubj = new List<Subject>();
        List<Student_subject> listStudSubj = new List<Student_subject>();
        List<Specialty_Subject> listSpecSubj = new List<Specialty_Subject>();
        List<ListPriority> listPriority = new List<ListPriority>();

        public List<Abiturient> ReadAbitInLict()
            {
                SqlDataReader readAbit = generation.ReadTable("Student");
                 while (readAbit.Read())
                {
                    listAbit.Add(new Abiturient { ID_abit = Convert.ToInt32(readAbit.GetValue(0)), Fio = readAbit.GetValue(1).ToString()});
                }
                return listAbit;
            }

        public List<Specialty> ReadSpecInLict()
            {
                SqlDataReader readSpec = generation.ReadTable("Specialty");
                  while (readSpec.Read())
                {
                    listSpec.Add(new Specialty { ID_spec = Convert.ToInt32(readSpec.GetValue(0)), Name = readSpec.GetValue(1).ToString(), Amount = Convert.ToInt32(readSpec.GetValue(2)) });
                }
                return listSpec;
            }

        public List<Subject> ReadSubjInLict()
            {
               SqlDataReader readSubj = generation.ReadTable("Subject");
             while (readSubj.Read())
                {
                    listSubj.Add(new Subject { ID_sub = Convert.ToInt32(readSubj.GetValue(0)), Name = readSubj.GetValue(1).ToString() });
                }
                return listSubj;
            }

        public List<Specialty_Subject> ReadSpecSubjInLict()
            {
                 SqlDataReader readSpecSubj = generation.ReadTable("Spec_subj");
                while (readSpecSubj.Read())
                {
                    listSpecSubj.Add(new Specialty_Subject { ID = Convert.ToInt32(readSpecSubj.GetValue(0)), Id_specialty = Convert.ToInt32(readSpecSubj.GetValue(1)), Id_subject = Convert.ToInt32(readSpecSubj.GetValue(2)) });
                }
                return listSpecSubj;
            }

        public List<Student_subject> ReadStudSubjInLict()
            {
              SqlDataReader readStudSubj = generation.ReadTable("Student_subj");
                    while (readStudSubj.Read())
                {
                    listStudSubj.Add(new Student_subject { ID = Convert.ToInt32(readStudSubj.GetValue(0)), Id_student = Convert.ToInt32(readStudSubj.GetValue(1)), Id_subject = Convert.ToInt32(readStudSubj.GetValue(2)), Scores=Convert.ToInt32(readStudSubj.GetValue(3)) });
                }
                return listStudSubj;
            }
                           
        public List<ListPriority> ReadPriorInLict()
            {
              SqlDataReader readPrior = generation.ReadTable("Priority");
            while (readPrior.Read())
                {
                    listPriority.Add(new ListPriority { ID = Convert.ToInt32(readPrior.GetValue(0)), ID_student = Convert.ToInt32(readPrior.GetValue(1)), ID_specialty = Convert.ToInt32(readPrior.GetValue(2)), Prior = Convert.ToInt32(readPrior.GetValue(3)), Sum = Convert.ToInt32(readPrior.GetValue(4)) });
                }
                return listPriority;
            }

    }
}
