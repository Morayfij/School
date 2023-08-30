using System;
using System.Collections.Generic;
namespace Student
{
class Student
{
    public string Name { get; set; }
    public string SchoolID { get; set; }
    public string NationalID { get; set; }
    public double Grade { get; set; }
    public string Course { get; set; }
}

class StudentManagement
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
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
            Student student = students[index];
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

}
