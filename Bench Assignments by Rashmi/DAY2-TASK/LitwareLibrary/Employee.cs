using System;

namespace LitwareLibrary
{
    public class Employee
    {
        private int EmpNo { get; set; }
        private string EmpName { get; set; }
        private double Salary { get; set; }
        private double HRA { get; set; }
        private double TA { get; set; }
        private double DA { get; set; }
        private double PF { get; set; }
        private double TDS { get; set; }
        private double NetSalary { get; set; }
        private double GrossSalary { get; set; }

        public Employee(int empno, string empname, double salary)
        {
            this.EmpNo = empno;
            this.EmpName = empname;
            this.Salary = salary;
            if (salary < 5000)
            {
                this.HRA = salary * (0.10);
                this.TA = salary * (0.05);
                this.DA = salary * (0.15);
            }
            else if (salary >= 5000 && salary < 10000)
            {
                this.HRA = salary * (0.15);
                this.TA = salary * (0.10);
                this.DA = salary * (0.20);
            }
            else if (Salary >= 10000 && salary < 15000)
            {
                this.HRA = salary * (0.20);
                this.TA = salary * (0.15);
                this.DA = salary * (0.25);
            }
            else if (Salary >= 15000 && salary < 20000)
            {
                this.HRA = salary * (0.25);
                this.TA = salary * (0.20);
                this.DA = salary * (0.30);
            }
            else
            {
                this.HRA = salary * (0.30);
                this.TA = salary * (0.25);
                this.DA = salary * (0.35);
            }
            this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;
        }

        public void CalculateSalary()
        {
            this.PF = this.GrossSalary * (0.10);
            this.TDS = this.GrossSalary * (0.18);
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            Console.WriteLine("Gross Salary : "+this.GrossSalary);
            Console.WriteLine("Net Salary : "+this.NetSalary);
        }

    }
}

