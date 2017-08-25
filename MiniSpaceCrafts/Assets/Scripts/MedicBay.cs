public class MedicBay : ShipPartBase
{
    public float healPercentPerCard;

    public MedicBay(float maxHealth, int level, float healPercentPerCard) : base(maxHealth, level)
    {
        this.healPercentPerCard = healPercentPerCard;
    }

}

