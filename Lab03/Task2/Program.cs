using System;
using Task1;

class Program
{
    static void Main()
    {
        Person pers1 = new Person();
        Person pers2 = new Person(100);
        Person pers3 = new Person("Ivan", 19);
        pers1.Print();
        pers2.Print();
        pers3.Print();  
    }
}

