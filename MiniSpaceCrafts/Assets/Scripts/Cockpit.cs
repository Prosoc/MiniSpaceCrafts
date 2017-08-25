public class Cockpit : ShipPartBase
{
    public int maxPilotNumber;
    public Crew[] pilots;

    public Cockpit(float maxHealth, int maxPilotNumber, int level) : base(maxHealth, level)
    {
        this.maxPilotNumber = maxPilotNumber;
        this.pilots = new Crew[this.maxPilotNumber];
        this.level = level;
    }
}

