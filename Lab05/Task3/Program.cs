namespace Task3
{
    class Program
    {
        static void Main()
        {
            try
            {
                Pizza pizza = CreatePizza();
                ReadToppings(pizza);
                PrintPizza(pizza);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static Pizza CreatePizza()
        {
            string[] pizzaLine = Console.ReadLine().Split(' ');
            Pizza pizza = new Pizza(pizzaLine[1]);
            string[] doughLine = Console.ReadLine().Split(' ');
            Dough dough = new Dough(doughLine[1], doughLine[2], double.Parse(doughLine[3]));
            pizza.SetDough(dough);
            return pizza;       
        }

        static void ReadToppings(Pizza pizza)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] toppingLine = input.Split(' ');
                Topping topping = new Topping(toppingLine[1], double.Parse(toppingLine[2]));
                pizza.AddTopping(topping);   
            }    
        }

        static void PrintPizza(Pizza pizza)
        {
            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories():f2} Calories");
        }
    }    
}