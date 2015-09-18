using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Abiturient
{
   
    class SpecialtyReadClass
    {
        static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        static Generation_Class generation = new Generation_Class(connectionString);

         public void ReadTableSpec()
        {
            SpecialtyClass special = new SpecialtyClass();
            SqlDataReader readTableSpec = generation.ReadTable("Specialty");
            SqlDataReader readTableSpecSubj = generation.ReadTable("Spec_subj");
            SqlDataReader readTableAbitSpec1 = generation.ReadTable("Priority");
            SqlDataReader readSpecFIO = generation.ReadTable("Student");

            while (readTableSpec.Read())
            {
                special.ID = Convert.ToInt32(readTableSpec.GetValue(0));
                special.Specialty = readTableSpec.GetValue(1).ToString();
                special.Amount = Convert.ToInt32(readTableSpec.GetValue(2));
                while (readTableSpecSubj.Read())
                {
                    if (Convert.ToInt32(readTableSpec.GetValue(0)) == Convert.ToInt32(readTableSpecSubj.GetValue(1)))
                    {
                        special.listSubj.Add(new SubjectClass { ID = Convert.ToInt32(readTableSpecSubj.GetValue(1)), Subject = readTableSpecSubj.GetValue(2).ToString() });
                    }
                }
                while (readTableAbitSpec1.Read())
                {
                    if (Convert.ToInt32(readTableSpec.GetValue(0)) == Convert.ToInt32(readTableAbitSpec1.GetValue(2)))
                    {
                        while(readSpecFIO.Read())
                        {
                            if(Convert.ToInt32(readTableAbitSpec1.GetValue(1)) == Convert.ToInt32(readSpecFIO.GetValue(0)))
                            {
                                special.listAbitur.Add(new AbiturientClass { ID = Convert.ToInt32(readSpecFIO.GetValue(0)), FIO = readSpecFIO.GetValue(1).ToString() });
                            }
                        }
                    }
                }
            }   
        } 
    }
}
