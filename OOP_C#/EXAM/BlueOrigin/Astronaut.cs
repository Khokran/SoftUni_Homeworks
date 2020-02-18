namespace BlueOrigin
{
    public class Astronaut
    {
        private string spaceship;
        private string testAstronautNumber;

        public Astronaut(string name, double oxygenInPercentage)
        {
            this.Name = name;
            this.OxygenInPercentage = oxygenInPercentage;
        }

        public Astronaut(string spaceship, string testAstronautNumber)
        {
            this.spaceship = spaceship;
            this.testAstronautNumber = testAstronautNumber;
        }

        public string Name { get;  }

        public double OxygenInPercentage { get; }
        public double Make { get; set; }
        public double AstronautNumber { get; set; }
    }
}
