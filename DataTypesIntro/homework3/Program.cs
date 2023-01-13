// See https://aka.ms/new-console-template for more information


internal class Program
{
    static void Main(string[] args)
    {
        Employee marchenko = new Employee("Aleksandr", "Marchenko ", "Teacher", 4525);
        Employee ivashko = new Employee("Vadim", "Ivashko ", "Teacher", 2133);
        Employee kozlov = new Employee("Aleksei", "Kozlov ", "Rector", 4556);

        Employee[] employees = { marchenko, ivashko, kozlov };

        Room auxiliary = new Room(1, "Auxiliary room");
        Room lectureHall = new Room(2, "Lecture hall");
        Room laboratory = new Room(3, "Laboratory");
        Room suminarRoom = new Room(4, "Suminar room");
       
        Room[] RoomsBuilding1 = { laboratory, lectureHall, suminarRoom, auxiliary };
        Room[] RoomsBuilding2 = { laboratory, lectureHall, suminarRoom, auxiliary };
        Room[] RoomsBuilding3 = { laboratory, lectureHall, suminarRoom, auxiliary };

        AdressBuilding officialAdrss = new AdressBuilding("Minsk", "Matusevicha", 22);
        AdressBuilding adressBuilding2 = new AdressBuilding("Minsk", "Matusevicha", 23);
        AdressBuilding adressBuilding3 = new AdressBuilding("Minsk", "Matusevicha", 24);



        Building building1 = new Building(RoomsBuilding1, officialAdrss);
        Building building2 = new Building(RoomsBuilding1, adressBuilding2);
        Building building3 = new Building(RoomsBuilding1, adressBuilding3);

        Building[] buildings = { building1, building2, building3 };

        University university = new University(kozlov, employees, buildings, officialAdrss);

        Console.WriteLine(university.Rector.LastName);
    }
}
//
