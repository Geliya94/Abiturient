﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abiturient
{
    class SpecialtyClass
    {
        public int ID { get; set; }
        public string Specialty { get; set; }
        public int Amount { get; set; }
        public List<SubjectClass> listSubj = new List<SubjectClass>();
       public List<AbiturientClass> listAbitur = new List<AbiturientClass>();
    }
}
