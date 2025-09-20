using System;
using System.Runtime.InteropServices;
using Task4;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Employee[] arr = ReadEmployees(n);

        string bestDepartment = FindBestDepartment(arr);
        Console.WriteLine($"Highest avg salary - {bestDepartment}");

        SortBySalary(arr);
        Print(arr, bestDepartment);
    }

    static Employee[] ReadEmployees(int n)
    {
        Employee[] arr = new Employee[n];
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            Employee emp = new Employee(input[0], double.Parse(input[1]), input[2], input[3]);
            if (input.Length == 5)
            {
                if (input[4].Contains("@"))
                {
                    emp.Email = input[4];
                }
                else
                {
                    emp.Age = int.Parse(input[4]);
                }
            }    
            else if (input.Length == 6)
            {
                emp.Email = input[4];
                emp.Age = int.Parse(input[5]);
            }
            arr[i] = emp;
        }    
        return arr;
    }

    static string FindBestDepartment(Employee[] arr)
    {
        string bestDep = "";
        double bestAvg = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            string depart = arr[i].Department;
            double sum = 0;
            int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j].Department == depart)
                {
                    sum += arr[j].Salary;
                    count++;
                }
                double avg = sum / count;
                if (avg > bestAvg)
                {
                    bestAvg = avg;
                    bestDep = depart;
                }
            }
        }    
        return bestDep;
    }

    static void SortBySalary(Employee[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i].Salary < arr[j].Salary)
                {
                    Employee temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
    static void Print(Employee[] arr, string dep)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Department == dep)
            {
                Console.WriteLine($"{arr[i].Name} {arr[i].Salary} {arr[i].Email} {arr[i].Age}");
            }
        }
    }
}