namespace Task3;

public class Mission
{
    public string CodeName { get; }
    public string State { get; private set; }

    public Mission(string codeName, string state)
    {
        if (state != "inProgress" && state != "Finished")
            throw new ArgumentException("Invalid mission state");

        CodeName = codeName;
        State = state;
    }

    public void CompleteMission()
    {
        State = "Finished";
    }

    public override string ToString()
    {
        return $"  Code Name: {CodeName} State: {State}";
    }
}