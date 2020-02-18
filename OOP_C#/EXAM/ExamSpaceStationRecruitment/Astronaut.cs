namespace ExamSpaceStationRecruitment
{
    class Astronaut
    {
        private string name;
        private int age;
        private string country;

        public Astronaut(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age; 
            this.Country = country;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Astronaut: {Name}, {Age} ({Country})";
        }
    }
}
