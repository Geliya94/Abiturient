using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abiturient
{
    public class List
    {
        public int ID_student { get; set; }
        public int ID_specialty { get; set; }
        public int Prio { get; set; }
        public int Sum { get; set; }
    }

    public class ListSpec
    {
        public int ID { get; set; }
        public string Specialty { get; set; }
        public int Amount { get; set; }
    }

    public class ListFirstSpec
    {
        public int ID { get; set; }
        public int ID_specialty {get; set;}
        public int ID_student { get; set; }
        public int Prio { get; set; }
        public int Sum { get; set; }
    }



    public class ListPriority
    {
        public int ID { get; set; }
        public int ID_student { get; set; }
        public int ID_specialty { get; set; }
        public int Prior { get; set; }
        public int Sum { get; set; }
    }

    partial class Specialty
    {
        public int ID_spec { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
    }

    partial class Abiturient
    {
        public int ID_abit { get; set; }
        public string Fio { get; set; }
    }

    partial class Subject
    {
        public int ID_sub { get; set; }
        public string Name { get; set; }
    }

    public class Specialty_Subject
    {
        public int ID { get; set; }
        public int Id_specialty { get; set; }
        public int Id_subject { get; set; }
    }

    public class Student_subject
    {
        public int ID { get; set; }
        public int Id_student { get; set; }
        public int Id_subject { get; set; }
        public int Scores { get; set; }
    }
}
