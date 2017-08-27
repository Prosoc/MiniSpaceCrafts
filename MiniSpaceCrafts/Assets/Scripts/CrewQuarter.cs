using System.Collections.Generic;
public class CrewQuarter : ShipPartBase
{
    public int maxCrewNumber;
    public List<Crew> crew = new List<Crew>();
    
    public CrewQuarter(int level, string name, FType type, float maxHealth, int maxCrewNumber) : base(level, name, type, maxHealth)
    {
        this.maxCrewNumber = maxCrewNumber;
    }
}

