using Task3;
using System;

class Program
{
    static void Main()
    {
        IPrivate[] allPrivates = new IPrivate[100];
        int privateCount = 0;
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] parts = input.Split(' ');
            string type = parts[0];

            if (type == "Private")
            {
                IPrivate p = new Private(parts[1], parts[2], parts[3], double.Parse(parts[4]));
                allPrivates[privateCount++] = p;
                Console.WriteLine(p);
            }
            else if (type == "LeutenantGeneral")
            {
                IPrivate[] subs = new IPrivate[100];
                int subCount = 0;

                for (int i = 5; i < parts.Length; i++)
                {
                    for (int j = 0; j < privateCount; j++)
                    {
                        if (allPrivates[j].Id == parts[i])
                        {
                            subs[subCount++] = allPrivates[j];
                            break;
                        }
                    }
                }

                IPrivate[] realSubs = new IPrivate[subCount];
                for (int i = 0; i < subCount; i++)
                {
                    realSubs[i] = subs[i];
                }

                var lg = new LeutenantGeneral(parts[1], parts[2], parts[3], double.Parse(parts[4]), realSubs);
                Console.WriteLine(lg);
            }
            else if (type == "Engineer")
            {
                string corps = parts[5];
                if (corps != "Airforces" && corps != "Marines")
                    continue;

                int repairCount = (parts.Length - 6) / 2;
                Repair[] repairs = new Repair[repairCount];
                int idx = 0;

                for (int i = 6; i < parts.Length - 1; i += 2)
                {
                    string part = parts[i];
                    int hours = int.Parse(parts[i + 1]);
                    repairs[idx++] = new Repair(part, hours);
                }

                var e = new Engineer(parts[1], parts[2], parts[3], double.Parse(parts[4]), corps, repairs);
                Console.WriteLine(e);
            }
            else if (type == "Commando")
            {
                string corps = parts[5];
                if (corps != "Airforces" && corps != "Marines")
                    continue; 

                Mission[] missions = new Mission[50];
                int missionCount = 0;

                for (int i = 6; i < parts.Length - 1; i += 2)
                {
                    string codeName = parts[i];
                    string state = parts[i + 1];

                    if (state == "inProgress" || state == "Finished")
                    {
                        missions[missionCount++] = new Mission(codeName, state);
                    }
                }

                Mission[] realMissions = new Mission[missionCount];
                for (int i = 0; i < missionCount; i++)
                    realMissions[i] = missions[i];

                var c = new Commando(parts[1], parts[2], parts[3], double.Parse(parts[4]), corps, realMissions);
                Console.WriteLine(c);
            }
            else if (type == "Spy")
            {
                var s = new Spy(parts[1], parts[2], parts[3], int.Parse(parts[4]));
                Console.WriteLine(s);
            }
        }    
    }
}