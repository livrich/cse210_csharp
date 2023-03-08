using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Student s = new Student("Olivia", "Richards", 8728);
        Console.WriteLine(s._firstName);
        
    }
}

public class Person
{
    public string _firstName;
    public string _lastName;

    public Person(string first, string last)
    {
        _firstName = first;
        _lastName = last;
    }
}

public class Student : Person
{
    public int _id;

    public Student(string first, string last, int id) : base(first, last)
    {
        _id = id;
    }
}