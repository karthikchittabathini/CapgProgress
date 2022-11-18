using LinqTask;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(String[] args)
    {
        // create a object for the employee class
        Employee emp = new Employee();


        // create a generic employee list 
        var EmployeeList = new List<Employee>() 
        { new Employee(){EmployeeId = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateOnly(1984, 11, 16), DOJ = new DateOnly(2011, 6 ,8), City = "Mumbai"},
          new Employee(){EmployeeId = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateOnly(1984, 8, 20), DOJ = new DateOnly(2012, 7 ,7), City = "Mumbai"},
          new Employee(){EmployeeId = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateOnly(1987, 11, 14), DOJ = new DateOnly(2015, 4,12), City = "Pune"},
          new Employee(){EmployeeId = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateOnly(1990, 6, 3), DOJ = new DateOnly(2016, 2 ,2), City = "Pune"},
          new Employee(){EmployeeId = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateOnly(1991, 3, 8), DOJ = new DateOnly(2016, 2 ,2), City = "Mumbai"},
          new Employee(){EmployeeId = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateOnly(1989, 11, 7), DOJ = new DateOnly(2014, 8 ,8), City = "Chennai"},
          new Employee(){EmployeeId = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateOnly(1989, 12, 2), DOJ = new DateOnly(2015, 6 ,1), City = "Mumbai"},
          new Employee(){EmployeeId = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateOnly(1993, 11, 11), DOJ = new DateOnly(2014,11,6), City = "Chennai"},
          new Employee(){EmployeeId = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateOnly(1992, 8, 12), DOJ = new DateOnly(2014, 12,3), City = "Chennai"},
          new Employee(){EmployeeId = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateOnly(1991, 4, 12), DOJ = new DateOnly(2016, 1,2), City = "Pune"},
        };


        //  ************************************************************************************
        //  (a) - Display details of all employees - using LINQ Query Syntax
        var AllEmployees = from employee in EmployeeList
                           select employee;

        // iterating through the given list
        //foreach(var x in AllEmployees)
        //{
        //    Console.WriteLine(x.LastName + " - " +x.Title);
        //}



        //  ************************************************************************************
        // (b) - Display details of employee whose location is not Mumbai - using LINQ method syntax

        var NotMumbaiEmployees = EmployeeList.Where(emp => emp.City != "Mumbai").ToList();

        //foreach(var x in NotMumbaiEmployees)
        //{
        //    Console.WriteLine(x.EmployeeId + "- " + x.LastName + " - " + x.City);
        //}



        //  ************************************************************************************
        // (c) - Display details of employee whose title is AsstManager

        var AsstMangerEmployee = from employee in EmployeeList
                                 where (employee.Title == "AsstManager")
                                 select employee;

        // iterate through the AsstManagerEmployee
        //foreach(var x in AsstMangerEmployee)
        //{
        //    Console.WriteLine(x.LastName + " - " + x.Title + " - " + x.City);
        //}



        //  ************************************************************************************
        // (d) - Display details of all the employees whose last name starts with s
        var LastnameSEmployees = from s in EmployeeList
                                 where s.LastName.ToLower().StartsWith("s")
                                 select s;
        // iteration
        //foreach(var s in LastnameSEmployees)
        //{
        //    Console.WriteLine(s.LastName);
        //}




        //  ************************************************************************************
        // (e) - Display all the employees who have joined before 1/1/2015

        var emps = EmployeeList.Where(emp => emp.DOJ < new DateOnly(2015, 1, 1)).ToList();

        //iteration through list
        //foreach(var x in emps)
        //{
        //    Console.WriteLine(x.LastName + " - " + x.DOJ);
        //}



        //  ************************************************************************************
        // (f) - Display a list of all employee whose date of birth is after 1/1/1990

        var Emps = EmployeeList.Where(emp => emp.DOJ > new DateOnly(1990,1,1)).ToList();



        //  ************************************************************************************
        // (g) - Display a list of all employees whose designation is consultant and associate

        var employees = EmployeeList.Where(emp => (emp.Title.ToLower() == "consultant" && emp.Title.ToLower() == "associate")).ToList();

        // iterating through the list
        //foreach(var employee in employees)
        //{
        //    Console.WriteLine(employee.LastName + " - " + employee.Title);
        //}


        //  ************************************************************************************
        // (h) - Display total count of all the employees

        var TotalEmployeeCount = EmployeeList.Count();

        //count of the employee
        //Console.WriteLine(TotalEmployeeCount);


        //  ************************************************************************************
        // (i) - Display a count of all employee belonging to Chennai

        var TotalChennaiEmployees = EmployeeList.Where(x => x.Title.ToLower() == "chennai").Count();

        //Console.WriteLine(TotalChennaiEmployees);


        //  ************************************************************************************
        // (j) - Display highest employee id 

        var highestId = EmployeeList.Max(x => x.EmployeeId);
        //Console.WriteLine(highestId);


        //  ************************************************************************************
        // (k) - Display total count of employees who joined after 1/1/2015

        var DjCount = EmployeeList.Where(x => x.DOJ > new DateOnly(2015,1,1)).Count();

        //Console.WriteLine(DjCount);


        //  ************************************************************************************
        // (l) - Display total number of employees who designation is not associate

        var NotAssociateCount = EmployeeList.Where(emp => emp.Title.ToLower() != "associate").Count();

        //Console.WriteLine(NotAssociateCount);


        //  ************************************************************************************
        // (m) - Display total number of employees based on city

        var TotalBasedOnCity = EmployeeList.GroupBy(x => x.City).ToList();

        // iterating and showing city with toatal employee count
        //foreach (var x in TotalBasedOnCity)
        //{
        //    Console.WriteLine(x.Key + " - " + x.Count());
        //}



        //  ************************************************************************************
        // (n) - Display a total number of employees based title

        var Employeess = EmployeeList.GroupBy(x => x.Title).ToList();

        //foreach(var x in Employeess)
        //{
        //    Console.WriteLine(x.Key + " - " + x.Count());
        //}


        //  ************************************************************************************
        // (o) - Display the employee who is youngest

        var answer = EmployeeList.Min(x => x.DOB);

        //Console.WriteLine(answer);
    }
}