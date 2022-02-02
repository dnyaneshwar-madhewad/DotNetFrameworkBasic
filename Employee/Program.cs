using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Emp Net Calacution");

            Employee e1 = new Employee();
            Employee o1 = new Employee(1, "Dnayneshwar", 12000, 10);
            Employee o2 = new Employee(1, "Dnyaneshwar", 123465);
            Employee o3 = new Employee(1, "Dnyaneshwar");
            Employee o4 = new Employee(1);
            Employee o5 = new Employee();

            e1.Name = "Dnyaneshwar";
            Console.WriteLine(e1.Name);
            e1.EmpNo = 111;
            Console.WriteLine(e1.EmpNo);
            e1.DeptNo = 10;
            Console.WriteLine(e1.DeptNo);
            e1.Basic = 40000;
            Console.WriteLine(e1.Basic);
            Console.WriteLine(Decimal.Round(e1.GetNetSalary(), 2));
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public Employee() { }
        public Employee(int empno, string name, int basic, short deptno)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
            this.deptno = deptno;
        }
        public Employee(int empno, string name, int basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }
        public Employee(int empno, string name)
        {
            this.empno = empno;
            this.name = name;

        }

        public Employee(int empno)
        {
            this.empno = empno;
        }


        private decimal HRA, DA, GS, incometax, netsalary;

        private string name;
        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
            }

            get
            {
                return name;
            }
        }

        private int empno;
        public int EmpNo
        {
            set
            {
                if (value > 0)
                    empno = value;
            }

            get
            {
                return empno;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 20000 && value < 50000)
                    basic = value;
            }

            get
            {
                return basic;
            }
        }

        private short deptno;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptno = value;
            }

            get
            {
                return deptno;
            }
        }


        public decimal GetNetSalary()
        {
            this.HRA = (((decimal)10 / 100) * this.Basic);
            Console.WriteLine(this.HRA);
            Console.WriteLine(this.Basic);
            this.DA = (((decimal)73 / 100) * this.Basic);
            this.GS = (this.Basic + this.DA + this.HRA);
            this.incometax = (((decimal)30 / 100) * this.GS);
            this.netsalary = (this.GS - this.incometax);

            return this.netsalary;
        }
    }
}