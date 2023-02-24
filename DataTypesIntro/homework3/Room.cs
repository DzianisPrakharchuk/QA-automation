namespace homework3;

public class Room
{
    private int _roomNumber;
    public int RoomNumber
    {
        get
        {
            return _roomNumber;
        }
        set
        {
            if (value > 0 && value < 1000)
            {
                _roomNumber = value;
            }
        }
    }
    public string RoomType { get; set; }
    public Room(int number, string type)
    {
        RoomNumber = number;
        RoomType = type;
    }
    public override bool Equals(object? obj)
    {
        if (obj != null && obj is Room room)
        {
            return _roomNumber == room._roomNumber 
                && RoomType == room.RoomType;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return _roomNumber.GetHashCode() + RoomType.GetHashCode();
    }
}

