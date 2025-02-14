using System.Security.Cryptography.X509Certificates;

Student student1 = new Student(101);
student1.Name = "Ali";
student1.Grade = 85;
Console.WriteLine(student1.GetStudentInfo());
Console.WriteLine($"Passed: {student1.IsPassed()}");

Student student2 = new Student(102);
student2.Name = "An";
student2.Grade = 150; // Нодуруст, бояд 0 гузошта шавад.
Console.WriteLine(student2.GetStudentInfo());
Console.WriteLine($"Passed: {student2.IsPassed()}");


public class Student(int ID)
{
    public string Name;
    public int Grade;
    public string GetStudentInfo()
    {
        return $"Name: {Name}, ID: {ID}";
    }
    public string IsPassed()
    {
        if(Grade>=60 && Grade<=100)
        {
            return "True";
        }
        return "False";
    }
}