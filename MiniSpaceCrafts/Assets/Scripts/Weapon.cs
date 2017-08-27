public class Weapon : ShipPartBase
{
    
    public int realoadTurns;
    public int currentRealoadTurns = 0;
    public float damage;
    public float accuracy;
    public WType weaponType;
    public bool isAimed = true;

    

    public Weapon(int level, string name, FType type, float damage, float maxHealth, int realoadTurns, float accuracy, WType weaponType) : base(level, name, type, maxHealth)
    {
        this.realoadTurns = realoadTurns;
        this.damage = damage;
        this.accuracy = accuracy;
        this.weaponType = weaponType;
    }
}

