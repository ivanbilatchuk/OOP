namespace Task3
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public string Corps { get; }

        protected SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            if (corps != "Airforces" && corps != "Marines")
                throw new ArgumentException("Invalid corps");
            Corps = corps;
        }
    }
}