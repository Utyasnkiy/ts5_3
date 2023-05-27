using System;
using System.Collections.Generic;

// Definition of the interface Employee
interface Employee
{
    string Name { get; set; }
    void Work();
    void Rest();
}

// Definition of the abstract class Engineer, implementing the Employee interface
abstract class Engineer : Employee
{
    public string Name { get; set; }

    public abstract void Work();

    public void Rest()
    {
        Console.WriteLine("Engineer is resting.");
    }

    public abstract void AnotherMethod();
}

// Definition of the class Supervisor, inheriting from the abstract class Engineer
class Supervisor : Engineer
{
    public string Position { get; set; }

    public override void Work()
    {
        Console.WriteLine("Supervisor is working.");
    }

    public override void AnotherMethod()
    {
        Console.WriteLine("Supervisor's additional method.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of objects of type Employee
        List<Employee> employees = new List<Employee>();

        // Create objects and add them to the list
        Supervisor supervisor1 = new Supervisor();
        supervisor1.Name = "John";
        supervisor1.Position = "Senior Supervisor";
        employees.Add(supervisor1);

        Supervisor supervisor2 = new Supervisor();
        supervisor2.Name = "Alice";
        supervisor2.Position = "Junior Supervisor";
        employees.Add(supervisor2);

        // Interact with the objects in the list
        foreach (Employee employee in employees)
        {
            Console.WriteLine("Name: " + employee.Name);
            employee.Work();
            employee.Rest();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}