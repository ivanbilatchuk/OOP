namespace Task3;

public interface ICommando : ISpecialisedSoldier
{
    Mission[] Missions { get; }
}