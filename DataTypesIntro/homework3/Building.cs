using System;

internal class Building
{
   
    public Room[] Rooms { get; set; }
    public AdressBuilding AddressBulding { get; set; }

    public Building(Room[] rooms, AdressBuilding addressBulding)
    {
        Rooms = rooms;
        AddressBulding = addressBulding;
    }
}


//Создать классы Building и Room ( в здании массив помещений),
//каждое помещение имеет назначение- лекционное, лабораторное, семинарское, вспомогательное)