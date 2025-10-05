using System;
using Task4;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] foods = input.Split(' ');
        FoodFactory foodFactory = new FoodFactory();
        int totalHappiness = 0;
        for (int i = 0; i < foods.Length; i++)
        {
            Food food = foodFactory.GetFood(foods[i]);
            totalHappiness += food.HappinessPoints;
        }    
        MoodFactory moodFactory = new MoodFactory();
        Mood mood = moodFactory.GetMood(totalHappiness);
        Console.WriteLine(totalHappiness);
        Console.WriteLine(mood.Name);   
    }
    
}