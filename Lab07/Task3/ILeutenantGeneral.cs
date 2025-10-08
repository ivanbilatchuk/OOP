using System.Runtime.InteropServices.ComTypes;

namespace Task3;

public interface ILeutenantGeneral : IPrivate
{
    IPrivate[] Privates { get; }
}