﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceExam
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private MyDbContext db;

        public Service1()
        {
            db = new MyDbContext();
        }

        public Employee AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }

        public List<Employee> FindAllEmployee()
        {
            return db.Employees.ToList();
        }

        public List<Employee> SearchByDepartment(string department)
        {
            var list = db.Employees.Where(e => e.Department == department);
            return list.ToList();
        }
    }
}