namespace SAT_Scores
{
    class StudentScore
    {
        // Properties
        public string Name { set; get; }
        public int Score { set; get; }

        // Constructor
        public StudentScore(string n, int s)
        {
            Name = n;
            Score = s;
        }
    }
}
