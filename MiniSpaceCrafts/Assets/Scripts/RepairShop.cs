public class RepairShop : ShipPartBase
{
    public float RepairPercentPerCard;

    public RepairShop(float maxHealth, int level, float RepairPercentPerCard) : base(maxHealth, level)
    {
        this.RepairPercentPerCard = RepairPercentPerCard;
    }
}