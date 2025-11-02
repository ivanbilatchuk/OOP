namespace Task1;

public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

public class NameChangeEventArgs : EventArgs
{
    public string Name { get; private set; }

    public NameChangeEventArgs(string name)
    {
        this.Name = name;
    }
}
public class Dispatcher
{
    private string name;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (!IsAlpha(value))
            {
                return;
            }    
            if (this.name != value)
            {
                this.name = value;
                this.OnNameChange(new NameChangeEventArgs(value));
            }
        }
    }
    private bool IsAlpha(string text)
    {
        foreach (char c in text)
        {
            if (!char.IsLetter(c))
                return false;
        }
        return true;
    }

    public event NameChangeEventHandler NameChange;

    protected virtual void OnNameChange(NameChangeEventArgs args)
    {
        if (this.NameChange != null)
        {
            this.NameChange(this, args);
        }
    }
}