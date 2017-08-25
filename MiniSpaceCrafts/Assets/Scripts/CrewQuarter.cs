using System.Collections.Generic;
public class CrewQuarter : ShipPartBase
{
    public int maxCrewNumber;
    public List<Crew> crew;

    public CrewQuarter(float maxHealth, int maxCrewNumber, int level) : base(maxHealth, level)
    {
        this.maxCrewNumber = maxCrewNumber;
        this.level = level;
    }
}

