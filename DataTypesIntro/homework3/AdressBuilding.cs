
namespace homework3;

public class AdressBuilding
{
    public string City { get; set; }
    public string Street { get; set; }

    private int _buildingNumber;
    public int BuildingNumber
    {
        get
        {
            return _buildingNumber;
        }
        set
        {
            if (value > 0 && value < 1000)
            {
                _buildingNumber = value;
            }
        }
    }
    public AdressBuilding (string city, string street, int buildingNumber)
    {
        City = city;
        Street = street;
        _buildingNumber = buildingNumber;
    }
    public override bool Equals(object? obj)
    {
        if (obj != null && obj is AdressBuilding adress)
        {
            return City == adress.City 
                && Street == adress.Street 
                && _buildingNumber == adress._buildingNumber;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return City.GetHashCode() + Street.GetHashCode() + _buildingNumber;
    }
}

