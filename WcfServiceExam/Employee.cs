﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceExam
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double Salary { get; set; }

        [DataMember]
        public string Department { get; set; }
    }
}