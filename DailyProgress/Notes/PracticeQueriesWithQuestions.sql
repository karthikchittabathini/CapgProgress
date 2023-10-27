-- create a table EmployeeDetails.
create table EmployeeDetails
(
EmpId int,
FullName varchar(25),
ManagerId int,
DateOfJoining Date,
City varchar(20)
);


-- create another table EmployeeSalary.
create table EmployeeSalary
(
EmpId int,
Project varchar(5),
Salary int,
Variable int
);


-- insert data into the EmployeeDetails table.
insert into EmployeeDetails values (121,'John Snow', 321, '2019-01-31','Toronto');
insert into EmployeeDetails values(321, 'Walter White', 986, '2020-01-30','California');
insert into EmployeeDetails values(421, 'Kuldeep Rana', 876, '2021-11-27','New Delhi');
insert into EmployeeDetails values(521, 'Karthik', 946, '2000-04-17', 'Ongole');
 
 -- Display data from the EmployeeDetails table.
 select * from EmployeeDetails

 -- insert data into the EmployeeSalary
 insert into EmployeeSalary values(121,'P1', 8000,500);
 insert into EmployeeSalary values(321,'P2',10000,1000);
 insert into EmployeeSalary values(421,'P1',12000,0);

 -- Display data from the EmployeeSalary table.
 select * from EmployeeSalary

 ---------------------------------------------------------------
 -------------------------- Queries---------------------------
 ---------------------------------------------------------------

 -- 1. write a sql query to fetch empid and full name of all the employees working under the manger with id 986.

 select empid, fullname from EmployeeDetails where ManagerId = 986;

 -- 2. Write an sql query to fetch the different projects available form the emplyeesalary table.
 select distinct(project) from EmployeeSalary;

 -- 3. Write an sql query to fetch the count of employees working in project p1.
 select count(*) as EmpCount from EmployeeSalary where Project = 'P1';

 -- 4. Write an sql query to find the maximum, minimum, and average salary of the employees.
 select min(salary) as minsalary, max(salary) as maxsalary, AVG(salary) as avgsalary from EmployeeSalary;

 -- 5. Write an sql query to find the employee id whose salary lies in the range of 9000 and 15000.
 select empid, salary from EmployeeSalary where Salary between 9000 and 15000;

 -- 6. Write an sql query to fetch those employees who live in tornoto and work under the manager with managerid - 321.
 select * from EmployeeDetails where city = 'Toronto' and ManagerId = 321;

 -- 7. Write an sql query to fetch all the employees who either live in california or work under a manager with managerid - 321.
 select * from EmployeeDetails where city = 'california' or ManagerId = 321;

 -- 8. Write an sql query to fetch all those employees who work on projects other than p1.
 select * from EmployeeDetails where EmpId In (select empId from EmployeeSalary where project != 'P1');

 -- 9. Write an sql query to display the total salary of each employee adding the salary with the variable value.
 select salary+variable as totalsalary from EmployeeSalary;

-- 10. Write an sql query to fetch the employees whose name begins with any two characters, followed by a text 'hn'
-- and ends with any sequence of characters.
select fullname from EmployeeDetails where fullname like '__hn%';

-- 11. Write an sql query to fetch all the empIds which are present in either of the tables. - 'employeeDetails' and 'Employeesalary'.
-- we can use union for combining two results and it will return unique rows.
select empid from EmployeeDetails union select empid from EmployeeSalary;

-- 12. Write an sql query to fetch common records between two tables.
select EmpId from EmployeeDetails where EmpId in(select empid from EmployeeSalary);

-- 13. Write a sql query to fetch records that are present in one table but not in another table.
select * from EmployeeDetails where not  EmpId in(select empid from EmployeeSalary);

-- 14. Write an sql query to fetch the empids that are present in both the tables EmployeesDetails and EmployeeSalary.
select d.empid from EmployeeDetails as d inner join EmployeeSalary as a on d.EmpId = a.EmpId;

-- 15. Write an sql query to fetch the empids that are present in employeedetails but not in employeesalary.
select empid from EmployeeDetails where empid not in (select empid from EmployeeSalary);

-- 16. Write an sql query to fetch the employee's full names and replace the space with '-'.
select REPLACE(fullname, ' ', '-') from EmployeeDetails;

-- 17. Write an sql query to fetch the position of a given character(s) in a field.
select CHARINDEX('n', fullname) as MatchPosition from EmployeeDetails;

-- 18. Write an sql query to display both the empid and managerid together.
select concat(empid, '-',managerid) as empidmanagerid from EmployeeDetails

-- 19. Write a query to fetch only the first name(string before space) from the fullname column of the employee details table.
select SUBSTRING(fullname, 1, (charindex(' ', fullname+' ')-1)) from EmployeeDetails;

-- 20. Write an sql query to uppercase the name of the employee and lowercase the city values.
select UPPER(fullname) as EmpName, lower(city) as city from EmployeeDetails;

-- 21. Write an sql query to find the count of the total occurrences of a particular character - 'n' in the fullname field.
select fullname, (len(fullname)-len(replace(fullname, 'n', ''))) from EmployeeDetails;

-- 22. Write an sql query to update the employee names by leading and trailing spaces.
update EmployeeDetails set FullName = LTRIM(RTRIM(fullname));

-- 23. Fetch all the employees who are not working on an project
select * from EmployeeDetails where empid not in(select empid from EmployeeSalary where Project is not null);

-- 24. Write an sql query to fetch employee names having a salary greater than or equal to 5000 and less than or equal to 10000.
select fullname from EmployeeDetails where empid in(select empid from EmployeeSalary where Salary between 5000 and 10000);

-- 25. Write an sql query to find the current date-time.
select GETDATE();

-- 26. Write an sql query to fetch all the employee details from the employeedetails table who joined in the year 2020.
select * from EmployeeDetails where DateOfJoining between '2020-01-01' and '2020-12-31';

-- 27. Write an sql query to fetch all employee records from the employeedetails table who have a salary record in the employeesalary table.
select * from EmployeeDetails where empid in (select empid from EmployeeSalary where salary is not null);

-- 28. Write an sql query to fetch the project-wise count of employees sorted by project's count in descending order.
select project,count(empid) as empcount from EmployeeSalary group by project order by count(empid) desc;

-- 29. Write a query to fetch employee names and salary records. Display the employee details even if the salary record is not present for the employee.
select d.fullname, s.Salary from EmployeeDetails as d
full outer join EmployeeSalary as s on d.EmpId = s.EmpId;

-- 30. Write a sql query to join 3 tables.
-- select column1, column2 from tableA join tableB on tableA.column3 = tableB.Column3 join tableC on tableA.column4 = tableC.column4

-- 31. Write a sql query to fetch all the employees who are also managers from the employeedetails table.
select distinct d.fullname from EmployeeDetails as d inner join EmployeeDetails as e on d.EmpId = e.ManagerId;

-- 32. Write an sql query to fetch duplicate records from employeeDetails (without considering the primary key - empid).
select fullname, managerid, DateOfJoining,City,count(*) from EmployeeDetails group by FullName, ManagerId, DateOfJoining, city having COUNT(*) > 1;