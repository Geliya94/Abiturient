using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace Abiturient
{
    class Generation_Class
    {
        string connectionstring = "";
        public Generation_Class(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
       /* static string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\BD_RPIS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        SqlConnection con = new SqlConnection(constring);*/
        public void GenAdd(int n, string nameTable, string parametr, DataGridView DGV_abiturient, string name)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter.InsertCommand = new SqlCommand("INSERT INTO " + nameTable+ " (" + parametr + ") VALUES (@FIO)", con);
            adapter.InsertCommand.Parameters.Add("@FIO", SqlDbType.VarChar);
            for (int i = 0; i < n; i++)
            {
                adapter.InsertCommand.Parameters[0].Value = name + i.ToString();
                adapter.InsertCommand.ExecuteNonQuery();
            }
            con.Close();
        }

        public void WriterTableStaudent(string nameTable, DataGridView DGV_abiturient)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlDataAdapter adapter_read = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter_read.SelectCommand = new SqlCommand("SELECT * from " + nameTable, con);
            SqlDataReader table_read = adapter_read.SelectCommand.ExecuteReader();

            while (table_read.Read())
            {
                DGV_abiturient.Rows.Add(table_read.GetValue(0).ToString(), table_read.GetValue(1).ToString());
            }

            con.Close();
        }



        public void GenAdd1(int n, string nameTable, string parametr1,string parametr2, DataGridView DGV_abiturient, string name)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            Random rn = new Random();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter.InsertCommand = new SqlCommand("INSERT INTO " + nameTable + " (" + parametr1+","+ parametr2+ ") VALUES (@FIO, @Amount )", con);
            adapter.InsertCommand.Parameters.Add("@FIO", SqlDbType.VarChar);
            adapter.InsertCommand.Parameters.Add("@Amount", SqlDbType.Int);
            for (int i = 0; i < n; i++)
            {
                adapter.InsertCommand.Parameters[0].Value = name + i.ToString();
                adapter.InsertCommand.Parameters[1].Value = rn.Next(20, 30);
                adapter.InsertCommand.ExecuteNonQuery();
            }

            con.Close();
        }

        public void Spec_Sub(string nameTable, string parametr1, string parametr2, int value1, int value2)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            Random rn = new Random();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter.InsertCommand = new SqlCommand("INSERT INTO " + nameTable + " (" + parametr1 + "," + parametr2 + ") VALUES (@value1, @value2 )", con);
            adapter.InsertCommand.Parameters.Add("@value1", SqlDbType.Int);
            adapter.InsertCommand.Parameters.Add("@value2", SqlDbType.Int);
            adapter.InsertCommand.Parameters[0].Value = value1;
            adapter.InsertCommand.Parameters[1].Value = value2;
            adapter.InsertCommand.ExecuteNonQuery();
            con.Close();
        }

        public void Stud_Sub(string nameTable, string parametr1, string parametr2,string parametr3, int value1, int value2,int value3)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            Random rn = new Random();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter.InsertCommand = new SqlCommand("INSERT INTO " + nameTable + " (" + parametr1 + "," + parametr2 +","+parametr3 +") VALUES (@value1, @value2,@value3 )", con);
            adapter.InsertCommand.Parameters.Add("@value1", SqlDbType.Int);
            adapter.InsertCommand.Parameters.Add("@value2", SqlDbType.Int);
            adapter.InsertCommand.Parameters.Add("@value3", SqlDbType.Int);
            adapter.InsertCommand.Parameters[0].Value = value1;
            adapter.InsertCommand.Parameters[1].Value = value2;
            adapter.InsertCommand.Parameters[2].Value = value3;
            adapter.InsertCommand.ExecuteNonQuery();
            con.Close();
        }

        public void WriterTableStaudent1(string nameTable, DataGridView DGV_abiturient)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlDataAdapter adapter_read = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter_read.SelectCommand = new SqlCommand("SELECT * from " + nameTable, con);
            SqlDataReader table_read = adapter_read.SelectCommand.ExecuteReader();

            while (table_read.Read())
            {
                DGV_abiturient.Rows.Add(table_read.GetValue(0).ToString(), table_read.GetValue(1).ToString(), table_read.GetValue(2).ToString());
            }

            con.Close();
        }
      /*  public void WriterTableStaudent12(string nameTable, DataGridView DGV_abiturient)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlDataAdapter adapter_read = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter_read.SelectCommand = new SqlCommand("SELECT * from " + nameTable, con);
            SqlDataAdapter read_spec = new SqlDataAdapter("SELECT * from Specialty", con);
            read_spec.SelectCommand = new SqlCommand("SELECT * from Specialty", con);
            SqlDataAdapter read_subj = new SqlDataAdapter("SELECT * from Subject", con);
            read_subj.SelectCommand = new SqlCommand("SELECT * from Subject", con);
            SqlDataReader table_read = adapter_read.SelectCommand.ExecuteReader();
            SqlDataReader table_read1 = read_spec.SelectCommand.ExecuteReader();
            SqlDataReader table_read2 = read_subj.SelectCommand.ExecuteReader();
            while (table_read.Read())
            {
                while ()
                if (Convert.ToInt32(table_read.GetValue(1))==)
                DGV_abiturient.Rows.Add(table_read.GetValue(0).ToString(), table_read.GetValue(1).ToString(), table_read.GetValue(2).ToString());
            }

            con.Close();
        }
        */
        public void WriterTableStudentSubj(string nameTable, DataGridView DGV_abiturient)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlDataAdapter adapter_read = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter_read.SelectCommand = new SqlCommand("SELECT * from " + nameTable, con);
            SqlDataReader table_read = adapter_read.SelectCommand.ExecuteReader();

            while (table_read.Read())
            {
                DGV_abiturient.Rows.Add(table_read.GetValue(0).ToString(), table_read.GetValue(1).ToString(), table_read.GetValue(2).ToString(), table_read.GetValue(3).ToString());
            }

            con.Close();
        }
        public SqlDataReader ReadTable(string nameTable)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open(); 

            SqlDataAdapter adapter_read = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter_read.SelectCommand = new SqlCommand("SELECT * from " + nameTable, con);
            SqlDataReader table_read = adapter_read.SelectCommand.ExecuteReader();

            return table_read;
        }

        //public SqlDataReader Count(string nameTable)
        //{
        //    SqlConnection con = new SqlConnection(connectionstring);
        //    con.Open();

        //    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from " + nameTable, con);
        //    adapter.SelectCommand = new SqlCommand("SELECT * from " + nameTable + "; Select @@rowcount", con);
             
        //   SqlDataReader read = adapter.SelectCommand.ExecuteReader();
        //   return read;
        //}

        public SqlDataReader IdSubj(int value)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlDataAdapter adapter_read = new SqlDataAdapter("SELECT * from Spec_subj", con);
            adapter_read.SelectCommand = new SqlCommand("SELECT ID_subject from Spec_subj Where ID_specialty = @value ", con);
            adapter_read.SelectCommand.Parameters.Add("@value", SqlDbType.Int);
            adapter_read.SelectCommand.Parameters[0].Value = value;

            SqlDataReader table_read = adapter_read.SelectCommand.ExecuteReader();

            return table_read;
        }

        public SqlDataReader Score(int value, int value1)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlDataAdapter adapter_read = new SqlDataAdapter("SELECT * from Student_subj", con);
            adapter_read.SelectCommand = new SqlCommand("SELECT Scores from Student_subj Where ID_subj = @value AND ID_student = @value1 ", con);
            adapter_read.SelectCommand.Parameters.Add("@value", SqlDbType.Int);
            adapter_read.SelectCommand.Parameters.Add("@value1", SqlDbType.Int);
            adapter_read.SelectCommand.Parameters[0].Value = value;
            adapter_read.SelectCommand.Parameters[1].Value = value1;

            SqlDataReader table_read = adapter_read.SelectCommand.ExecuteReader();

            return table_read;
        }

        public void Priority(string nameTable, string parametr1, string parametr2, string parametr3, string parametr4, int value1, int value2, int value3, int value4)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            Random rn = new Random();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter.InsertCommand = new SqlCommand("INSERT INTO " + nameTable + " (" + parametr1 + "," + parametr2 + "," + parametr3 + "," + parametr4 + ") VALUES (@value1, @value2, @value3, @value4)", con);
            adapter.InsertCommand.Parameters.Add("@value1", SqlDbType.Int);
            adapter.InsertCommand.Parameters.Add("@value2", SqlDbType.Int);
            adapter.InsertCommand.Parameters.Add("@value3", SqlDbType.Int);
            adapter.InsertCommand.Parameters.Add("@value4", SqlDbType.Int);
            adapter.InsertCommand.Parameters[0].Value = value1;
            adapter.InsertCommand.Parameters[1].Value = value2;
            adapter.InsertCommand.Parameters[2].Value = value3;
            adapter.InsertCommand.Parameters[3].Value = value4;
            adapter.InsertCommand.ExecuteNonQuery();
            con.Close();
        }



        public void WriterTablePriority(string nameTable, DataGridView DGV_abiturient)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlDataAdapter adapter_read = new SqlDataAdapter("SELECT * from " + nameTable, con);
            adapter_read.SelectCommand = new SqlCommand("SELECT * from " + nameTable, con);
            SqlDataReader table_read = adapter_read.SelectCommand.ExecuteReader();

            while (table_read.Read())
            {
                DGV_abiturient.Rows.Add(table_read.GetValue(0).ToString(), table_read.GetValue(1).ToString(), table_read.GetValue(2).ToString(), table_read.GetValue(3).ToString(), table_read.GetValue(4).ToString());
            }

            con.Close();
        }

        public int Sum(int idspec, int idstud)
        {
            int sum = 0;
            SqlDataReader readsubj = IdSubj(idspec);
            while (readsubj.Read())
            {
                SqlDataReader readScore = Score(Convert.ToInt32(readsubj.GetValue(0)), Convert.ToInt32(idstud));
                while (readScore.Read())
                {
                    sum += Convert.ToInt32(readScore.GetValue(0));
                }
            }
            return sum;
        }

        public void Delete(string nametable)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from " + nametable, con);
            adapter.DeleteCommand = new SqlCommand("Delete from " + nametable, con);
            adapter.DeleteCommand.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataReader Spiski(int value)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Priority", con);
            adapter.SelectCommand = new SqlCommand("SELECT * From Priority Where ID_specialty = @value", con);
            adapter.SelectCommand.Parameters.Add("@value", SqlDbType.Int);
            adapter.SelectCommand.Parameters[0].Value = value;
            SqlDataReader read = adapter.SelectCommand.ExecuteReader();
          //  con.Close();
            return read;
        }
    
    }
}
