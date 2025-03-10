﻿namespace Homework6; 
class Program 
{ 
static void Main(string[ ] args) 
{ // Answer Q1 and Q2
            // Create 2 Professors
            Professor professor1 = new Professor
            {
                ProfName = "Alice",
                ClassTeach = "Java"
            };
            professor1.SetSalary(9000);

            Professor professor2 = new Professor
            {
                ProfName = "Bob",
                ClassTeach = "Math"
            };
            professor2.SetSalary(8000);

            // Create 2 Students
            Student student1 = new Student
            {
                StudentName = "Lisa",
                ClassEnroll = "Java"
            };
            student1.SetGrade(90);

            Student student2 = new Student
            {
                StudentName = "Tom",
                ClassEnroll = "Math"
            };
            student2.SetGrade(80);

            // Print formatted Professor details
            Console.WriteLine($"Professor {professor1.ProfName} teaches {professor1.ClassTeach}, and the salary is: {professor1.GetSalary()}");
            Console.WriteLine($"Professor {professor2.ProfName} teaches {professor2.ClassTeach}, and the salary is: {professor2.GetSalary()}");

            // Print formatted Student details
            Console.WriteLine($"Student {student1.StudentName} enrolls {student1.ClassEnroll}, and the grade is: {student1.GetGrade()}");
            Console.WriteLine($"Student {student2.StudentName} enrolls {student2.ClassEnroll}, and the grade is: {student2.GetGrade()}");

            // Calculate and print salary difference
            double salaryDifference = professor1.GetSalary() - professor2.GetSalary();
            Console.WriteLine($"The salary difference between {professor1.ProfName} and {professor2.ProfName} is: {salaryDifference}");

            // Calculate and print total grade
            double totalGrade = student1.GetGrade() + student2.GetGrade();
            Console.WriteLine($"The total grade of {student1.StudentName} and {student2.StudentName} is: {totalGrade}");
        }
    } 

class Professor 
{ 
//Code for Professor Class
public string ProfName { get; set; }
        public string ClassTeach { get; set; }
        private double salary;

        public void SetSalary(double salary_amount)
        {
            salary = salary_amount;
        }

        public double GetSalary()
        {
            return salary;
        }
} 
class Student 
{ 
// Code for Student class
public string StudentName { get; set; }
        public string ClassEnroll { get; set; }
        private double studentGrade;

        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        public double GetGrade()
        {
            return studentGrade;
        } 
} 
