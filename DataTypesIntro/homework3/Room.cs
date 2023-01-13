using System;



    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }

        public Room(int number, string name)
        {
        RoomNumber = number;
        RoomName = name;
        }
    }
