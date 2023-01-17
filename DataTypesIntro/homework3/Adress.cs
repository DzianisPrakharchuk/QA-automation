namespace homework3
{
    public class Adress
    {
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
                if (value > 0 && value < 1000)
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
    }
}


