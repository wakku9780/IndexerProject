using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProject
{
   public class Employee
    {
        int Eno;
        double salary;
        string Ename, Job, Dname, Location;

        public Employee(int  Eno,string Ename,string Job,double Salary,string Dname,string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.salary = Salary;
            this.Dname = Dname;
            this.Location = Location;

        }
        public object this[int index]
        {
            get
            {
                if (index == 0) return Eno;
                else if (index == 1) return Ename;
                else if (index == 2) return Job;
                else if (index == 3) return salary;
                else if (index == 4) return Dname;
                else  if(index==5)   return Location;
                return null;
                


            }

            set
            {
                if (index == 0) Eno = (int)value;
                else if (index == 1) Ename = (string)value;
                else if (index == 2) Job = (string)value;
                else if (index == 3) salary = (double)value;
                else if(index==4)Dname = (string)value;
                else if(index==5)Location = (string)value;

            }
        }

    }
}
