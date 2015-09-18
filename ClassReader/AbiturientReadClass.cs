using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Abiturient
{
    class AbiturientReadClass
    {
        static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        static Generation_Class generation = new Generation_Class(connectionString);

        public void ReadTableAbit()
        {
            AbiturientClass abitur = new AbiturientClass();
            SqlDataReader readTableAbit = generation.ReadTable("Student");
            SqlDataReader readTableAbitSubj = generation.ReadTable("Student_subj");
            SqlDataReader readTableAbitSpec = generation.ReadTable("Priority");
            SqlDataReader readSpecAmount = generation.ReadTable("Specialty");
            
            while (readTableAbit.Read())
            {
                abitur.ID = Convert.ToInt32(readTableAbit.GetValue(0));
                abitur.FIO = readTableAbit.GetValue(1).ToString();
                while (readTableAbitSubj.Read())
                {
                    if (Convert.ToInt32(readTableAbit.GetValue(0)) == Convert.ToInt32(readTableAbitSubj.GetValue(1)))
                    {
                        abitur.listSubj.Add(new SubjectClass { ID = Convert.ToInt32(readTableAbitSubj.GetValue(2)), Subject = readTableAbitSubj.GetValue(2).ToString() });
                    }
                }
                while (readTableAbitSpec.Read())
                {
                    if (Convert.ToInt32(readTableAbit.GetValue(0)) == Convert.ToInt32(readTableAbitSpec.GetValue(1)))
                    {
                        abitur.listSpec.Add(new ListSpecClass { ID = Convert.ToInt32(readTableAbitSpec.GetValue(2)) });
                    }
                }
            }      
       }
    }
}
