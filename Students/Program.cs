/* Write a program that receives a count of students -n
 * and orders them by grade in descending order. Each student should have a 
 * First name (string), a Last name (string) and
 * a grade(a floating-point number).
 * 
 * Input
 * •On the first line, you are going to receive n - the count of students
 * •On the next n lines, you will be receiving the info about the students in 
 * the following format: "{first name} {second name} {grade}"
 * 
 * Output
 * •Print each student in the following format:
 * "{first name} {second name}: {grade}"
 * 
 * Example:
 * 
 * INPUT:       4
 *              Lakia Eason 3.90
 *              Prince Messing 5.49
 *              Akiko Segers 4.85
 *              Rocco Erben 6.00
 *              
 * OUTPUT:      Rocco Erben: 6.00
 *              Prince Messing: 5.49
 *              Akiko Segers: 4.85
 *              
 *solution by me, sstankov */

using System;

class Program
{
    static void Main()
    {
        //creating list that will store new students:
        List<Student> students = new List<Student>();

        //input:
        int studentsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentsCount; i++)
        {
            var studentInfo = Console.ReadLine().Split().ToArray();
            //creating new student each turn of the cycle:
            Student student = new Student(studentInfo[0],
                studentInfo[1], double.Parse(studentInfo[2]));
            students.Add(student);
        }

        //output, sorted by descending order:
        Console.WriteLine(String.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade)));
    }
}

public class Student
{//creating properties for the 'Student' class:
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    //constructor:
    public Student(string firstName, string lastName, double grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;
    }

    //creating override for ToString :
    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:f2}";
    }
}
