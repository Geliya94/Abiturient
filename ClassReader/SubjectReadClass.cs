using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace Abiturient
{
    class SubjectReadClass
    {
        static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        static Generation_Class generation = new Generation_Class(connectionString);
        
        public void ReadTableSubj()
        {
            SubjectClass subject = new SubjectClass();

            ReadTableListClass readTable = new ReadTableListClass();
            List<Subject> list = readTable.ReadSubjInLict();
            foreach (var i in list)
            {
                subject.ID = i.ID_sub;
                subject.Subject = i.Name;
            }
        }
    }
}
