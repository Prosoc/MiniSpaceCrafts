public class Reactor : ShipPartBase
{
    public float energy;
    public float maxEnergy;

    public float energyGeneration;
    
    public Reactor(float maxHealth, float maxEnergy, float energyGeneration, int level) : base(maxHealth, level)
    {
        this.maxEnergy = maxEnergy;
        this.energy = maxEnergy;
        this.energyGeneration = energyGeneration;
        this.level = level;
    }

    public void ReactorTurn()
    {
        
        if (energy < maxEnergy)
        {
            energy += energyGeneration;
            Logger.Instance.Log("Reactor", name, "Energy Generated");
        }
        else
        {
            Logger.Instance.Log("Reactor", name, "Idle");
        }
    }
}

