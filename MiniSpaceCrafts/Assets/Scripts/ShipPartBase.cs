public class ShipPartBase
{
    public string name;
    public string type;
    public float maxHealth;
    public float health;
    public int level;

    public ShipPartBase(string name, string type, float maxHealth, int level)
    {
        this.name = name;
        this.type = type;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.level = level;
    }
    public ShipPartBase(string name, float maxHealth, int level)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.level = level;
    }
    public ShipPartBase(float maxHealth, int level)
    {
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.level = level;
    }
}
