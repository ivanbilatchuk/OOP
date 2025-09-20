using System;
using Task1;

class Program
{
    static void Main()
    {
        Person pers1 = new Person();
        Person pers2 = new Person { Name = "Ivan", Age = 19 };
        Person pers3 = new Person("Vanya", 19);
        Person pers4 = new Person();
        pers4.Name = "Unknown";
        pers4.Age = 100;
        pers1.Print();
        pers2.Print();
        pers3.Print();
        pers4.Print(); 
    }
}