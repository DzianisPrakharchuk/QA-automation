using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Candidate
{
    internal class Candidate
    {
       

        public Person Person { get; set; }
        public SubjectScore[] SubjectScores { get; set; }

         public Candidate()
        {
        }

        public Candidate(Person person, SubjectScore[] subjectScores)
        {
            Person = person;
            SubjectScores = subjectScores;
        }
    }
}
