using System;

namespace EmployeeSpace{
class Employee{
    int id;
    string name;
    string department;
    float salary;
    char gender;
    public void AcceptDetails(){
        Console.WriteLine("Enter Employee Details: ");
        Console.WriteLine("Id:");
        id=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name:");
        name=Console.ReadLine();
        Console.WriteLine("Department:");
        department=Console.ReadLine();
        Console.WriteLine("Salary:");
        salary=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Gender:");
        gender=Convert.ToChar(Console.ReadLine());
    }
    public void DisplayDetails(){
        Console.WriteLine("Employee Details Are: ");
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Department: {department}"); 
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Gender: {gender}");
        
    }
}
}