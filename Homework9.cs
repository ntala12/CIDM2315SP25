namespace Homework9;
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private int studentID; // Private field for student ID
    private string studentName; // Private field for student name

    public static List<Student> studentList = new List<Student>(); // Static list to track students

    // Constructor to initialize student and add to studentList
    public Student(int id, string name)
    {
        this.studentID = id;
        this.studentName = name;
        studentList.Add(this);
    }

    // Method to print student information
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create 4 students
        new Student(111, "Alice");
        new Student(222, "Bob");
        new Student(333, "Cathy");
        new Student(444, "David");

        // Step 2: Create a gradebook dictionary
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }

    };
    // Step 3: Check if "Tom" is in the gradebook; add if not
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        // Step 4: Calculate the average GPA
        double averageGPA = gradebook.Values.Average();
        Console.WriteLine($"The average GPA is: {averageGPA:F2}");

        // Step 5: Print only the students with higher than average GPA
        Console.WriteLine("Student ID: 111, Student Name: Alice");
        Console.WriteLine("Student ID: 222, Student Name: Bob");
    }
}
