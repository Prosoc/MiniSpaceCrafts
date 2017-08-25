public class Weapon
{
    public string name;
    public string type;
    public float maxHealth;
    public float health;
    public int level;
    public int realoadTurns;
    public int currentRealoadTurns;
    public bool canShoot = true;
    public bool isAimed = true;

    public Weapon(string name, string type, float maxHealth, int level, int realoadTurns)
    {
        this.name = name;
        this.type = type;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.level = level;
        this.realoadTurns = realoadTurns;
        this.currentRealoadTurns = 0;
    }

    public void Shoot()
    {
        if (canShoot && isAimed)
        {
            canShoot = false;
            currentRealoadTurns = 0;
            Logger.Instance.Log("Weapon", name, "Weapon shot");
        }
        else
        {
            Logger.Instance.Log("Weapon", name, "Weapon can't shoot");
        }
    }

    
}

