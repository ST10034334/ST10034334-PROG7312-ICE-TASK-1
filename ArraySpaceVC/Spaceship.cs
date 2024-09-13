namespace ArraySpaceVC
{
    public class Spaceship
    {
        public string spaceshipName { get; set; }
        public string model { get; set; }
        public int crewCapacity { get; set; }
        public double maxSpeed { get; set; }
        public string status { get; set; }
        public DateOnly launchDate { get; set; }
        public string missionType { get; set; }

        public Spaceship(string spaceshipName, string model, int crewCapacity, double maxspeed, string status, DateOnly launchDate, string missionType)
        {
            this.spaceshipName = spaceshipName;
            this.model = model;
            this.crewCapacity = crewCapacity;
            this.maxSpeed = maxspeed;
            this.status = status;
            this.launchDate = launchDate;
            this.missionType = missionType;
        }

        public override string ToString()
        {
            return "\n*****************************\n" +
                   $"Name: {spaceshipName}\n" +
                   $"Model: {model}\n" +
                   $"Crew Capacity: {crewCapacity}\n" +
                   $"Max Speed: {maxSpeed}\n" +
                   $"Status: {status}\n" +
                   $"Launch Date: {launchDate}\n" +
                   $"Mission: {missionType}\n" +
                   "*****************************\n\n";
        }

    }
}
