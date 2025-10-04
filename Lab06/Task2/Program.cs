using System;
using Task2;

class Program
{
    static void Main()
    {
        try
        {
            string[] studentData = Console.ReadLine().Split(' ');
            string[] workerData = Console.ReadLine().Split(' ');
            Student student = new Student(studentData[0], studentData[1], studentData[2]);
            Worker worker = new Worker(workerData[0], workerData[1], decimal.Parse(workerData[2]), double.Parse(workerData[3]));
            Console.WriteLine(student + Environment.NewLine);
            Console.WriteLine(worker);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }  
}