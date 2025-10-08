namespace Task3
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Mission[] Missions { get; }

        public Commando(string id, string firstName, string lastName, double salary, string corps, Mission[] missions)
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = missions;
        }

        public override string ToString()
        {
            string result = base.ToString() + $"\nCorps: {Corps}\nMissions:";
            for (int i = 0; i < Missions.Length; i++)
                result += "\n" + Missions[i].ToString();
            return result;
        }
    }
}