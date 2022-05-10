﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfServiceExam
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name = MyConnectionString")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}