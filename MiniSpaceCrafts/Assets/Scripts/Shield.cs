using UnityEngine;
using System.Collections;

public class Shield : ShipPartBase
{
    public int layers;
    public float layerRegenTurnTime;
    public float energyPerFastRegenCard;

    public Shield(int level, string name, FType type, float maxHealth, int layers, float layerRegenTurnTime, float energyPerFastRegenCard) : base(level, name, type, maxHealth)
    {
        this.layers = layers;
        this.layerRegenTurnTime = layerRegenTurnTime;
        this.energyPerFastRegenCard = energyPerFastRegenCard;
    }
}
