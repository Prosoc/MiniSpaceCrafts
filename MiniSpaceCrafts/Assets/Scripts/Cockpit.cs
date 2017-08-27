using System.Collections.Generic;

public class Cockpit : ShipPartBase
{
    public int maxPilotNumber;
    public List<Crew> pilots = new List<Crew>();

    
    public Cockpit(int level, string name, FType type, float maxHealth, int maxPilotNumber) : base(level, name, type, maxHealth)
    {
        this.maxPilotNumber = maxPilotNumber;
    }
}

