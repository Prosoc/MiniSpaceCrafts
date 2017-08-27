public class Hull : ShipPartBase
{    
    public float maxArmour;
    public float armour;

    public Hull(int level, string name, FType type, float maxHealth, float maxArmour) : base(level, name, type, maxHealth)
    {
        this.maxArmour = maxArmour;
        this.armour = maxArmour;
    }

    public override string ToString()
    {
        return type + " Hull: HP " + maxHealth + "/" + health;
    }
}

