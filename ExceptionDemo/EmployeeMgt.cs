using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public  class Employee
    {

        public int Empid { get; set; }
        public string Empname { get; set; }
    }
    public class EmployeeMgt
    {
        List<Employee> emplist=new List<Employee>();
        public EmployeeMgt()
        {
            emplist.Add(new Employee { Empid=1,Empname="Arun"});

            emplist.Add(new Employee { Empid = 2, Empname = "Varun" });


            emplist.Add(new Employee { Empid = 3, Empname = "Anita" });

            emplist.Add(new Employee { Empid = 4, Empname = "Sunita" });


            emplist.Add(new Employee { Empid = 5, Empname = "Ankur" });


        }

        public Employee FindEmployee(int? empid)
        {
            Employee empdata=null;
            if (empid != null)
            {
                 empdata=emplist.Find(e => e.Empid == empid);
                if (empdata==null)
                {
                    throw new EmployeeNotFoundException("This empid doesn't exists");
                }


            }
            return empdata;
        }

    }
}
