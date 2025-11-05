namespace Task5;

public class Clinic
{
    private Pet[] rooms;

    public string Name { get; }
    public int RoomsCount => rooms.Length;

    public Clinic(string name, int roomsCount)
    {
        if (roomsCount % 2 == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Name = name;
        rooms = new Pet[roomsCount];
    }

    public bool Add(Pet pet)
    {
        int middle = rooms.Length / 2;
        if (rooms[middle] == null)
        {
            rooms[middle] = pet;
            return true;
        }

        for (int offset = 1; offset <= middle; offset++)
        {
            int left = middle - offset;
            int right = middle + offset;

            if (left >= 0 && rooms[left] == null)
            {
                rooms[left] = pet;
                return true;
            }
            if (right < rooms.Length && rooms[right] == null)
            {
                rooms[right] = pet;
                return true;
            }
        }

        return false;
    }

    public bool Release()
    {
        int middle = rooms.Length / 2;

        for (int i = middle; i < rooms.Length; i++)
        {
            if (rooms[i] != null)
            {
                rooms[i] = null;
                return true;
            }
        }

        for (int i = 0; i < middle; i++)
        {
            if (rooms[i] != null)
            {
                rooms[i] = null;
                return true;
            }
        }

        return false;
    }

    public bool HasEmptyRooms()
    {
        foreach (var room in rooms)
        {
            if (room == null) return true;
        }
        return false;
    }

    public void Print()
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            PrintRoom(i + 1);
        }
    }

    public void PrintRoom(int roomNumber)
    {
        Pet pet = rooms[roomNumber - 1];
        if (pet == null)
        {
            Console.WriteLine("Room empty");
        }
        else
        {
            Console.WriteLine(pet);
        }
    }
}