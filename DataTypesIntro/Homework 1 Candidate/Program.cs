namespace Homework_1_Candidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Adress adr1 = new Adress("Zhodino", "Mira", 15, 12);
            Person person1 = new Person("Aliaksei", "Kazlou", adr1);

            Adress adr2 = new Adress("Minsk", "Aerodromnaya", 1 , 22);
            Person person2 = new Person("Maksim", "Rubanau", adr2);

            Adress adr3 = new Adress("Minsk", "Matysevicha", 12, 16);
            Person person3 = new Person("Alesia", "Zabavskaia", adr3);

            Adress adr4 = new Adress("Minsk", "Krasivaya", 66, 31);
            Person person4 = new Person("Svetlana", "Zenkovich", adr4);

            Adress adr5 = new Adress("Minsk", "Pushkina", 18, 44);
            Person person5 = new Person("Victor", "Acramchuk", adr5);


            SubjectScore[] score1 = { new SubjectScore("Language", 8), new SubjectScore("Math", 10) };
            SubjectScore[] score2 = { new SubjectScore("Language", 7), new SubjectScore("Math", 9) };
            SubjectScore[] score3 = { new SubjectScore("Language", 6), new SubjectScore("Math", 7) };
            SubjectScore[] score4 = { new SubjectScore("Language", 5), new SubjectScore("Math", 9) };
            SubjectScore[] score5 = { new SubjectScore("Language", 4), new SubjectScore("Math", 6) };

            Candidate candidate1 = new Candidate(person1, score1);
            Candidate candidate2 = new Candidate(person2, score2);
            Candidate candidate3 = new Candidate(person3, score3);
            Candidate candidate4 = new Candidate(person4, score4);
            Candidate candidate5 = new Candidate(person5, score5);

            Candidate[] array = { candidate1, candidate2, candidate3, candidate4, candidate5 };


            foreach (Candidate candidate in array)
            {
                string street = candidate.Person.Adress.Street;
                Console.WriteLine(street);
            }

            int maxScore = 0;
            foreach (Candidate candidate in array)
            {
                SubjectScore[] subjectScores = candidate.SubjectScores;
                foreach (SubjectScore ss in subjectScores)
                {
                    if (ss.SubjectName.Equals("Language") && maxScore < ss.Score)
                        {
                        maxScore = ss.Score;
                    }
                }
                
            }
            Console.WriteLine(maxScore);

    }
    }
} 