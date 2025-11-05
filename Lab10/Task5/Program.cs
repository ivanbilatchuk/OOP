using Task5;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Pet> pets = new Dictionary<string, Pet>();
        Dictionary<string, Clinic> clinics = new Dictionary<string, Clinic>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string command = input[0];

            try
            {
                if (command == "Create")
                {
                    if (input[1] == "Pet")
                    {
                        string name = input[2];
                        int age = int.Parse(input[3]);
                        string kind = input[4];
                        pets[name] = new Pet(name, age, kind);
                    }
                    else if (input[1] == "Clinic")
                    {
                        string name = input[2];
                        int rooms = int.Parse(input[3]);
                        clinics[name] = new Clinic(name, rooms);
                    }
                }
                else if (command == "Add")
                {
                    string petName = input[1];
                    string clinicName = input[2];
                    if (!clinics[clinicName].Add(pets[petName]))
                        Console.WriteLine("False");
                    else
                        Console.WriteLine("True");
                }
                else if (command == "Release")
                {
                    string clinicName = input[1];
                    Console.WriteLine(clinics[clinicName].Release());
                }
                else if (command == "HasEmptyRooms")
                {
                    string clinicName = input[1];
                    Console.WriteLine(clinics[clinicName].HasEmptyRooms());
                }
                else if (command == "Print")
                {
                    string clinicName = input[1];
                    if (input.Length == 2)
                        clinics[clinicName].Print();
                    else
                        clinics[clinicName].PrintRoom(int.Parse(input[2]));
                }
            }
            catch
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}