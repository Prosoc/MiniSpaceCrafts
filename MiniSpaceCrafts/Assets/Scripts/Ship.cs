using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship{

    public Hull Hull;
    public int maxRoomNum = 3;
    public int currentRoomNum = 0;
    public ShipPartBase[] rooms;
    public ShipPartBase Cockpit;
    public List<CrewQuarter> Crewquarters = new List<CrewQuarter>();
    public List<Reactor> Reactors = new List<Reactor>();
    public int maxEngineNum = 1;
    public int currentEngineNum = 0;
    public List<Engine> Engines = new List<Engine>();
    public int maxWeaponNum = 1;
    public int currentWeaponNum = 0;
    public List<Weapon> Weapons = new List<Weapon>();
    public int maxShieldNum = 1;
    public int currentShieldNum = 0;
    public List<Shield> Shields = new List<Shield>();

    public Ship() { }
    

    public Ship(int maxRoomNum, int maxEngineNum, int maxWeaponNum, int maxShieldNum)
    {
        this.maxRoomNum = maxRoomNum;
        this.maxEngineNum = maxEngineNum;
        this.maxWeaponNum = maxWeaponNum;
        this.maxShieldNum = maxShieldNum;

        this.rooms = new ShipPartBase[this.maxRoomNum];
       
    }
    
    
    public bool AddWeapon(Weapon w)
    {
        if (currentWeaponNum < maxWeaponNum)
        {
            currentWeaponNum++;
            Weapons.Add(w);
            return true;
        }
        Debug.Log("Can't add weapon to ship: " + w.name);
        return false;
    }

    public bool AddEngine(Engine e)
    {
        if (currentEngineNum < maxEngineNum)
        {
            currentEngineNum++;
            Engines.Add(e);
            return true;
        }
        Debug.Log("Can't add engine to ship: " + e.name);
        return false;
    }

    public bool AddShield(Shield s)
    {
        if (currentShieldNum < maxShieldNum)
        {
            currentEngineNum++;
            Shields.Add(s);
            return true;
        }
        Debug.Log("Can't add shield to ship: " + s.name);
        return false;
    }

    public ShipPartBase PlaceRoomToRandomPos(ShipPartBase room)
    {
        int place = -1;
        if (currentRoomNum < maxRoomNum)
        {
            while (place == -1)
            {
                int r = Random.Range(0, rooms.Length - 1);
                if (rooms[r] == null)
                {
                    place = r;
                    rooms[r] = room;
                    return room;
                }
            }
        }
        return null;
    }
}

