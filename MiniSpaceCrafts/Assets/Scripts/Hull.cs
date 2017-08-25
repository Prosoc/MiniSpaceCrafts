public class Hull : ShipPartBase
{    
    public float maxArmour;
    public float armour;
    
    public Hull(string name, string type, float maxHealth, int level, float maxArmour) : base(name, type, maxHealth, level)
    {
        this.maxArmour = maxArmour;
        this.armour = maxArmour;
    }

    public override string ToString()
    {
        return type + " Hull: HP " + maxHealth + "/" + health;
    }
}

