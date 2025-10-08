using System.Runtime.InteropServices.ComTypes;

namespace Task3;

public interface ILeutenantGeneral : ISoldier
{
    IPrivate[] Privates { get; }
}