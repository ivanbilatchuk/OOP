using System;
using Task1;
class Program
{
    static void Main()
    {
        Dispatcher dispatcher = new Dispatcher();
        Handler handler = new Handler();
        dispatcher.NameChange += handler.OnDispatcherNameChange;

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            dispatcher.Name = input;
        }
    }
    
}