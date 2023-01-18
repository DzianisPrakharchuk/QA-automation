namespace homework3
{
    public class SubjectScore
    {
        public const int MaxScore = 100;
        public const int MinScore = 0;
        public string SubjectName { get; set; }
        private int _score;
        public int Score
        {
            get
            { 
                return _score;
            }
            set
            {
                if (value >= MinScore && value <= MaxScore)
                {
                    _score = value;
                }
            }
        }
    
        public SubjectScore(string subjectName, int score)
        {
            SubjectName = subjectName;
            _score = score;
        }
    }
}
