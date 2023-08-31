using System;
using System.Collections.Generic;

public class Student1
{
    public string Name { get; set; }
    public string SchoolID { get; set; }
    public string NationalID { get; set; }
    public double Grade { get; set; }
    public string Course { get; set; }
}

class StudentManagement
{
    private List<Student1> students = new List<Student1>();

    public void AddStudent(Student1 student1)
    {
        students.Add(student1);
        Console.WriteLine("Student added successfully!");
    }

    public void DeleteStudent(int index)
    {
        if (index >= 0 && index < students.Count)
        {
            students.RemoveAt(index);
            Console.WriteLine("Student deleted successfully!");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void ShowStudent(int index)
    {
        if (index >= 0 && index < students.Count)
        {
            Student1 student = students[index];
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"School ID: {student.SchoolID}");
            Console.WriteLine($"National ID: {student.NationalID}");
            Console.WriteLine($"Grade: {student.Grade}");
            Console.WriteLine($"Course: {student.Course}");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void ShowAllStudents()
    {
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"Student {i + 1}:");
            ShowStudent(i);
            Console.WriteLine();
        }
    }
}

 class Program
{
    public static void Main(string[] args)
    {
        StudentManagement studentManagement = new StudentManagement();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Delete student");
            Console.WriteLine("3. Show all students");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter school ID: ");
                    string schoolID = Console.ReadLine();
                    Console.Write("Enter national ID: ");
                    string nationalID = Console.ReadLine();
                    Console.Write("Enter grade: ");
                    double grade = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter course: ");
                    string course = Console.ReadLine();
                    studentManagement.AddStudent(new Student1 { Name = name, SchoolID = schoolID, NationalID = nationalID, Grade = grade, Course = course });
                    break;

                case 2:
                    Console.Write("Enter index of student to delete: ");
                    int indexToDelete = Convert.ToInt32(Console.ReadLine());
                    studentManagement.DeleteStudent(indexToDelete);
                    break;

                case 3:
                    studentManagement.ShowAllStudents();
                    break;

                case 4:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }
}
