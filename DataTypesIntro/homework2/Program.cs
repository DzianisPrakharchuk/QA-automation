
using homework2;

internal class Program
{
    static void Main(string[] args)
    {
        var marchenko = new Teacher(
            "Marchenko Aleksandr",
            4525, 
            new Course(
                "hydraulics",
                "basic hydraulics"));

        var ivashko = new Teacher(
            "Ivashko Vadim", 
            4733, 
            new Course(
                "machine parts",
                "introduction to engineering"));

        var kozlov = new Teacher(
            "Kozlov Aleksei", 
            4822, 
            new Course(
                "engineering graphics",
                "design basics"));

        var astashevich = new DegreeTeacher(
            "Astashevich Dmitry",
            6623, 
            new Course(
                "economics", 
                "trade relations"),
            "Bachelor's degree",
            "assistant professor");

        var yakimovich = new DegreeTeacher(
            "Yakimovich Oleg",
            3345, 
            new Course(
                "theoretical mechanics",
                "kinematics"),
            "Master's degree",
            "Professor");

        var maslovskaya = new DegreeTeacher(
            "Maslovskaya Kristina",
            5643, 
            new Course(
                "material resistance",
                "deformation theory"),
            "Doctoral degree",
            "Professor");

        var svirid = new SupportStaff(
            "Svirid Dmitry",
            8877,
            "mechanic");

        var saveliev = new SupportStaff(
            "Saveliv Nikolai",
            5567,
            "an electrician");

        var korneev = new SupportStaff(
            "Korneev Andrey",
            4432,
            "plumber");

        UniversityEmployee[] universityEmployees = 
        {
            marchenko,
            ivashko,
            kozlov,
            astashevich,
            yakimovich,
            maslovskaya,
            svirid,
            saveliev,
            korneev
        };
        
        Console.WriteLine(" University employees: \n");
             

        foreach (var UniversityEmployee  in universityEmployees)
        {
            Console.WriteLine(UniversityEmployee.Person + " " + UniversityEmployee.GetOfficialDuties());

        }

        Console.WriteLine(" ");

        Console.WriteLine("University teachers : \n");

        foreach (var UniversityEmployee in universityEmployees)
        {
            if (UniversityEmployee is Teacher)
            {
                Console.WriteLine(UniversityEmployee.Person + " " + UniversityEmployee.GetOfficialDuties());
            }
        }
    }
    

    }




//8.Создать массив сотрудников университета, включающий в себя как преподавателей, так и вспомогательный персонал
//9.Вывести на консоль всех сотрудников университета с описанием должностных обязанностей каждого
//10.Вывести на консоль только всех преподавателей