public class Reactor : ShipPartBase
{
    public float energy;
    public float maxEnergy;
    
    public Reactor(int level, string name, FType type, float maxHealth, float maxEnergy) : base(level, name, type, maxHealth)
    {
        this.maxEnergy = maxEnergy;
        this.energy = maxEnergy;
    }

}

