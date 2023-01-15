namespace homework3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee marchenko = new
            ("Aleksandr",
            "Marchenko ",
            "Teacher",
            4525);
            Employee ivashko = new
                ("Vadim",
                "Ivashko ",
                "Teacher",
                2133);
            Employee kozlov = new
                ("Aleksei",
                "Kozlov ",
                "Rector", 4556);

            Employee[] employees =
            {
            marchenko,
            ivashko,
            kozlov
        };

            Room auxiliary = new
                (1, "Auxiliary room");
            Room lectureHall = new
                (2, "Lecture hall");
            Room laboratory = new
                (3, "Laboratory");
            Room suminarRoom = new
                (4, "Suminar room");

            Room[] RoomsBuilding1 =
            {
            laboratory,
            lectureHall,
            suminarRoom,
            auxiliary
        };

            Room[] RoomsBuilding2 =
            {
            laboratory,
            lectureHall,
            suminarRoom,
            auxiliary
        };

            Room[] RoomsBuilding3 =
            {
            laboratory,
            lectureHall,
            suminarRoom,
            auxiliary
        };

            AdressBuilding officialAdrss = new
                ("Minsk",
                "Matusevicha",
                22);
            AdressBuilding adressBuilding2 = new
                ("Minsk",
                "Matusevicha",
                23);
            AdressBuilding adressBuilding3 = new
                ("Minsk",
                "Matusevicha",
                24);

            Building building1 = new
                (RoomsBuilding1,
                officialAdrss,
                234);
            Building building2 = new
                (RoomsBuilding2,
                adressBuilding2,
                235);
            Building building3 = new
                (RoomsBuilding3,
                adressBuilding3,
                236);

            Building[] buildings =
            {
            building1,
            building2,
            building3
        };

            University university = new(kozlov, employees, buildings, officialAdrss);

            Console.WriteLine(university.Rector.LastName);
        }
    }
}

//
