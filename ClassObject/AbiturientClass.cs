using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abiturient
{
    class AbiturientClass
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public List<SubjectClass> listSubj = new List<SubjectClass>();
        public List<ListSpecClass> listSpec = new List<ListSpecClass>(); 
    }
}
