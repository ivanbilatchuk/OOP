using Task3;

class Program
{
    static Dictionary<string, IEmployee> employees = new Dictionary<string, IEmployee>();
    static JobList jobList = new JobList();

    static void Main()
    {
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] parts = command.Split();

            if (parts[0] == "StandardEmployee")
            {
                employees[parts[1]] = new StandardEmployee(parts[1]);
            }
            else if (parts[0] == "PartTimeEmployee")
            {
                employees[parts[1]] = new PartTimeEmployee(parts[1]);
            }
            else if (parts[0] == "Job")
            {
                string jobName = parts[1];
                int hours = int.Parse(parts[2]);
                string employeeName = parts[3];
                Job job = new Job(jobName, hours, employees[employeeName]);
                jobList.Add(job);
            }
            else if (command == "Pass Week")
            {
                foreach (var job in new List<Job>(jobList))
                {
                    job.Update();
                }
            }
            else if (command == "Status")
            {
                foreach (var job in jobList)
                {
                    Console.WriteLine(job);
                }
            }
        }
    }
}