using Task12;

class Program
{
    static void Main()
    {
        List<CompanyOrder> orders = ReadOrders();
        PrintSummary(orders);
    }

    static List<CompanyOrder> ReadOrders()
    {
        int n = int.Parse(Console.ReadLine());
        List<CompanyOrder> result = new List<CompanyOrder>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine().Trim('|').Replace(" ", "");
            string[] parts = input.Split('-');
            string company = parts[0];
            int amount = int.Parse(parts[1]);
            string product = parts[2];

            result.Add(new CompanyOrder
            {
                Company = company,
                Product = product,
                Amount = amount
            });
        }
        return result;
    }

    static void PrintSummary(List<CompanyOrder> orders)
    {
        var companies = orders.GroupBy(x => x.Company).OrderBy(x => x.Key); 

        foreach (var companyGroup in companies)
        {
            var products = companyGroup.GroupBy(x => x.Product).Select(g => new
                {
                    Product = g.Key,
                    Total = g.Sum(x => x.Amount),
                    FirstIndex = companyGroup.ToList().FindIndex(x => x.Product == g.Key)
                }).OrderBy(x => x.FirstIndex).ToList();

            Console.Write(companyGroup.Key + ": ");

            for (int i = 0; i < products.Count; i++)
            {
                Console.Write(products[i].Product + "-" + products[i].Total);
                if (i < products.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}