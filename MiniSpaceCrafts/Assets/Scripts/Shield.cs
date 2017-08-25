using UnityEngine;
using System.Collections;

public class Shield : ShipPartBase
{
    public int layers;
    public float layerRegenTurnTime;
    public float energyPerFastRegenCard;

    public Shield(float maxHealth, int level, int layers, float layerRegenTurnTime, float energyPerFastRegenCard) : base(maxHealth, level)
    {
        this.layers = layers;
        this.layerRegenTurnTime = layerRegenTurnTime;
        this.energyPerFastRegenCard = energyPerFastRegenCard;
    }
}
