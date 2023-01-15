using System;

    internal class Room
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
            _roomNumber = number;
            RoomType = type;
        }
    }

