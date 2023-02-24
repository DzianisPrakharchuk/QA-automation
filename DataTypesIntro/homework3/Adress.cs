namespace homework3
{
    public class Adress
    {
        public const int MaxHouseNumber = 1000;
        public const int MinHouseNumber= 0;
        public string City { get; set; }
        public string Street { get; set; }
        private int _houseNumber;
        public int HouseNumber
        {
            get
            { 
                return _houseNumber;
            }
            set
            {
                if (value >= MinHouseNumber && value <= MaxHouseNumber)
                {
                    _houseNumber = value;
                }
            }
        }
        private int _flatNumber;
        public int FlatNumber
        {
            get
            {
                return _flatNumber;
            }
            set
            {
                if (value > 0 && value < 1000)
                {
                    _flatNumber = value;
                }
            }
        }

        public Adress(string city, string street, int houseNumber, int flatNumber)
        {
            City = city;
            Street = street;
            _houseNumber = houseNumber;
            _flatNumber = flatNumber;
        }
        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Adress adress)
            {
                return City == adress.City
                    && Street == adress.Street 
                    && _houseNumber == adress._houseNumber 
                    && _flatNumber == adress._flatNumber;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return City.GetHashCode() + Street.GetHashCode() + _houseNumber.GetHashCode() + _flatNumber.GetHashCode();
        }
    }
}


