using System.Collections.Generic;

public partial class ShipPartBase
{
    public string name;
    public FType type;
    public float maxHealth;
    public float health;
    public int level;
    public List<Card> deck = new List<Card>();

    public ShipPartBase(int level, string name, FType type, float maxHealth)
    {
        this.name = name;
        this.type = type;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.level = level;
    }
    public ShipPartBase(int level, string name, float maxHealth)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.level = level;
    }
    public ShipPartBase(int level, float maxHealth)
    {
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.level = level;
    }
}
