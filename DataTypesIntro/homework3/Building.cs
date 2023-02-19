namespace homework3
{
    internal class Building : UniversityAssets
    {
        public List<Room> Rooms { get; set; }
        public AdressBuilding AddressBulding { get; set; }
        public Building(
            List<Room> rooms,
            AdressBuilding addressBulding,
            int idNumber)
        : base(idNumber)
        {
            Rooms = rooms;
            AddressBulding = addressBulding;
        }
        public bool AddRoom(Room room)
        {
            if (Rooms.Contains(room))
            {
                return false;
            }
            Rooms.Add(room);
            
            return true;
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Building building)
            {
                return AddressBulding == building.AddressBulding 
                    && IdNumber == building.IdNumber;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return AddressBulding.GetHashCode();
        }
        
    }
}


//Создать классы Building и Room ( в здании массив помещений),
//каждое помещение имеет назначение- лекционное, лабораторное, семинарское, вспомогательное)