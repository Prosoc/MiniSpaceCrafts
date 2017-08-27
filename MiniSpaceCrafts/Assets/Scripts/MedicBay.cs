public class MedicBay : ShipPartBase
{
    public float healPercentPerCard;
    
    public MedicBay(int level, string name, FType type, float maxHealth, float healPercentPerCard) : base(level, name, type, maxHealth)
    {
        this.healPercentPerCard = healPercentPerCard;
    }
}

