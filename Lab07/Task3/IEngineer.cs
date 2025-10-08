namespace Task3;

public interface IEngineer : ISpecialisedSoldier
{
    Repair[] Repairs { get; }
}