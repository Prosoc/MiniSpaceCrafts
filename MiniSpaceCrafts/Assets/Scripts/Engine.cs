public class Engine : ShipPartBase
{
    public float jumpDistance;
    public float emergencyJumpTime;
    public float evadeChance;

    public Engine(int level, string name, FType type, float maxHealth, float jumpDistance, float emergencyJumpTime, float evadeChance) : base(level, name, type, maxHealth)
    {
        this.jumpDistance = jumpDistance;
        this.emergencyJumpTime = emergencyJumpTime;
        this.evadeChance = evadeChance;
    }
    
}

