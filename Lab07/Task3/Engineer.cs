namespace Task3
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Repair[] Repairs { get; }

        public Engineer(string id, string firstName, string lastName, double salary, string corps, Repair[] repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = repairs;
        }

        public override string ToString()
        {
            string result = base.ToString() + $"\nCorps: {Corps}\nRepairs:";
            for (int i = 0; i < Repairs.Length; i++)
                result += "\n" + Repairs[i].ToString();
            return result;
        }
    }
}