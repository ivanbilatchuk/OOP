namespace Task3
{
    public class LeutenantGeneral : Soldier, ILeutenantGeneral
    {
        public IPrivate[] Privates { get; }
        public double Salary { get; }

        public LeutenantGeneral(string id, string firstName, string lastName, double salary, IPrivate[] privates)
            : base(id, firstName, lastName)
        {
            Privates = privates;
            Salary = salary;       
        }

        public override string ToString()
        {
            string result = base.ToString() + "\nPrivates:";
            for (int i = 0; i < Privates.Length; i++)
                result += "\n" + "  " + Privates[i].ToString();
            return result;
        }
    }
}