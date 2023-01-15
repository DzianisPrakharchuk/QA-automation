using System;

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
}

