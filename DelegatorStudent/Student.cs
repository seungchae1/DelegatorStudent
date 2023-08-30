namespace DelegatorStudent
{
    internal class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public Student(string name, double score)
        {
            Name = name;
            Score = score;
        }
        public override string ToString()
        {
            return Name + " : " + Score;
        }
    }
}