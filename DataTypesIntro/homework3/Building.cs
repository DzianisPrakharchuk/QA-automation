using homework3;
using System;

internal class Building : UniversityAssets
{
    public Room[] Rooms { get; set; }
    public AdressBuilding AddressBulding { get; set; }
    public Building(
        Room[] rooms, 
        AdressBuilding addressBulding, 
        int idNumber)
    :base(idNumber)
        {
            Rooms = rooms;
            AddressBulding = addressBulding;
        }
}


//Создать классы Building и Room ( в здании массив помещений),
//каждое помещение имеет назначение- лекционное, лабораторное, семинарское, вспомогательное)