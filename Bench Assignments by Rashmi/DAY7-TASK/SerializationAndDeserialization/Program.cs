using SerializationAndDeserialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    public static void Main(String[] args)
    {
        // Initialize the object and assign values

        Employee emp = new Employee();

        emp.EmployeeId = 14218;
        emp.EmployeeName = "Karthik Chittabathini";
        emp.Salary = 39990;

        // Creating the file stream
        // Serialization 
        IFormatter formatter = new BinaryFormatter();

        Stream stream = new FileStream("D:\\MainFolder\\subfolder1\\employee.txt",FileMode.Create,FileAccess.Write);
        formatter.Serialize(stream, emp);
        stream.Close();



        // Deserialzation

        Stream stream1 = new FileStream("D:\\MainFolder\\subfolder1\\employee.txt", FileMode.Open, FileAccess.Read);

        Employee emp2 = (Employee)formatter.Deserialize(stream1);

        Console.WriteLine(emp2.EmployeeId + " - " + emp2.EmployeeName + " - " + emp2.Salary);

        Console.ReadLine();

    }
}