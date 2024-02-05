using System;
using System.Collections.Generic;

class Teacher
{
    public string Name { get; set; }
    public int ID { get; set; }
    public string Class { get; set; }
    public string Section { get; set; }
}

class Program
{
    static List<Teacher> teachers = new List<Teacher>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Teacher  2. Retrieve Teacher Details  3. Update Teacher Details  4. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTeacher();
                    break;
                case 2:
                    RetrieveTeacherDetails();
                    break;
                case 3:
                    UpdateTeacherDetails();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddTeacher()
    {
        Console.WriteLine("\nEnter Teacher Details:");
        Teacher teacher = new Teacher();
        Console.Write("Name: ");
        teacher.Name = Console.ReadLine();
        Console.Write("ID: ");
        teacher.ID = int.Parse(Console.ReadLine());
        Console.Write("Class and Section: ");
        teacher.Class = Console.ReadLine();

        teachers.Add(teacher);
        Console.WriteLine("Teacher details added successfully.");
    }

    static void RetrieveTeacherDetails()
    {
        Console.WriteLine("\nEnter Teacher ID to retrieve details: ");
        int id = int.Parse(Console.ReadLine());

        Teacher teacher = teachers.Find(t => t.ID == id);
        if (teacher != null)
        {
            Console.WriteLine("\nTeacher Details:");
            Console.WriteLine($"Name: {teacher.Name}");
            Console.WriteLine($"ID: {teacher.ID}");
            Console.WriteLine($"Class and Section: {teacher.Class}");
        }
        else
        {
            Console.WriteLine("Teacher details not found.");
        }
    }

    static void UpdateTeacherDetails()
    {
        Console.WriteLine("\nEnter Teacher ID to update details: ");
        int id = int.Parse(Console.ReadLine());

        Teacher teacher = teachers.Find(t => t.ID == id);
        if (teacher != null)
        {
            Console.WriteLine("\nEnter updated details:");
            Console.Write("Name: ");
            teacher.Name = Console.ReadLine();
            Console.Write("Class and Section: ");
            teacher.Class = Console.ReadLine();
            Console.WriteLine("Teacher details updated successfully.");
        }
        else
        {
            Console.WriteLine("Teacher details not found.");
        }
    }
}