using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship{

    public Hull hull;





}



public class Hull
{
    public string name;
    public string type;
    public int level;

    public float maxHealth;
    public float health;

    public float maxArmour;
    public float armour;

    public int roomNum = 1;
    public Room[] rooms;

    public Hull(string name, string type, int level, float maxHealth, float maxArmour, int roomNum)
    {
        this.name = name;
        this.type = type;
        this.level = level;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.maxArmour = maxArmour;
        this.armour = maxArmour;
        this.roomNum = roomNum;

        this.rooms = new Room[this.roomNum];
    }
}

public class Room
{
    public float maxHealth;
    public float health;

    public int roomSize;

    public Room(float maxHealth, float health, int roomSize)
    {
        this.maxHealth = maxHealth;
        this.health = health;
        this.roomSize = roomSize;
    }
}

public class Cockpit : Room
{
    public int maxPilotNumber;
    public Crew[] pilots;

    public Cockpit(float maxHealth, float health, int roomSize, int maxPilotNumber) : base(maxHealth, health, roomSize)
    {

        this.maxPilotNumber = maxPilotNumber;
        this.pilots = new Crew[this.maxPilotNumber];
    }
}

public class CrewQuarter : Room
{
    public int maxCrewNumber;

    public CrewQuarter(float maxHealth, float health, int roomSize, int maxCrewNumber) : base(maxHealth, health, roomSize)
    {
        this.maxCrewNumber = maxCrewNumber;
    }
}

public class Door {



}

public class Crew
{
    public string name;
    public float maxHealth;
    public float health;

    public float pilotingSkill;
    public float enginesSkill;
    public float shieldsSkill;
    public float weaponsSkill;
}

