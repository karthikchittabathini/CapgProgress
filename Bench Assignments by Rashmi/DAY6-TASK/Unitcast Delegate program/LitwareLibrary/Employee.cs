using System;

namespace LitwareLibrary
{
    interface Iprintable
    {
        void EmpDetails();
    }
    public class Employee : Iprintable
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
        private string Designation { get; set; }
        private int Kmstravelled { get; set; }

        public Employee(int empno, string empname, double salary, string desg, int kms)
        {
            this.Designation = desg;
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

            if(this.Designation == "manager")
            {
                this.GrossSalary = (this.GrossSalary + (this.GrossSalary*(0.08)) + (this.GrossSalary * (0.13))+ (this.GrossSalary * (0.03)));
            }
            else if(this.Designation == "marketingexecutive")
            {
                this.Kmstravelled = kms;
                this.GrossSalary = (this.GrossSalary + 1000 + (this.Kmstravelled*5));
            }
            else
            {
                this.GrossSalary = this.GrossSalary;
            }
        }

        public void CalculateSalary()
        {
            this.PF = this.GrossSalary * (0.10);
            this.TDS = this.GrossSalary * (0.18);
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            Console.WriteLine("Gross Salary : "+this.GrossSalary);
            Console.WriteLine("Net Salary : "+this.NetSalary);
        }

        public void EmpDetails()
        {
            Console.WriteLine("The designation of employee is " + this.Designation);
            Console.WriteLine("Gross Salary : " + this.GrossSalary);
            Console.WriteLine("Net Salary : " + this.NetSalary);
        }

        public void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

