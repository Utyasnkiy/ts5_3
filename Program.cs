using System;
using System.Collections.Generic;

interface Employee
{
    string Name { get; set; }
    void Work();
    void Rest();
}

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
        List<Employee> employees = new List<Employee>();

        Supervisor supervisor1 = new Supervisor();
        supervisor1.Name = "John";
        supervisor1.Position = "Senior Supervisor";
        employees.Add(supervisor1);

        Supervisor supervisor2 = new Supervisor();
        supervisor2.Name = "Alice";
        supervisor2.Position = "Junior Supervisor";
        employees.Add(supervisor2);
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
