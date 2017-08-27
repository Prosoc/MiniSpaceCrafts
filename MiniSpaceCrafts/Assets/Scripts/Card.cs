using UnityEngine;

public class Card{

    public string Name;
    public string Description;
    public int EnergyNeed;
    public Color Color;



    public Card(string name, string description, int energyNeed)
    {
        this.Name = name;
        this.Description = description;
        this.EnergyNeed = energyNeed;
    }

    public delegate void use();
    public event use UseEvent;

    public void Use()
    {
        UseEvent();
    }

}
