public class RepairShop : ShipPartBase
{
    public float RepairPercentPerCard;
    
    public RepairShop(int level, string name, FType type, float maxHealth, float RepairPercentPerCard) : base(level, name, type, maxHealth)
    {
        this.RepairPercentPerCard = RepairPercentPerCard;
    }
}