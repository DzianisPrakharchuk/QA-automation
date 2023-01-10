using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Candidate
{
    internal class SubjectScore
    {
        public string SubjectName { get; set; }
        public int Score { get; set; }

        public SubjectScore(string subjectName, int score)
        {
            SubjectName = subjectName;
            Score = score;
        }
    }
}
