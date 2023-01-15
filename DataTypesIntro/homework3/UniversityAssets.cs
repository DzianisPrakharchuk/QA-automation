
using System;

namespace homework3;



public abstract class UniversityAssets
{
    private int _idNumber;
    
    public int IdNumber
    {
        get
        {
            return _idNumber;
        }
        set
        {
            if (value > 0)
            {
                _idNumber = value;
            }
        }
    }
    public UniversityAssets(int idNumbr)
    {
        IdNumber = idNumbr;
    }
}


