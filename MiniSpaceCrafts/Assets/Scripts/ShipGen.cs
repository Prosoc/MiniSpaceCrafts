using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class ShipGen {

    static Dictionary<int, string> hulls = new Dictionary<int, string>();
    static Dictionary<int, string> engines = new Dictionary<int, string>();
    static Dictionary<int, string> cockpits = new Dictionary<int, string>();
    static Dictionary<int, string> weaponControlls = new Dictionary<int, string>();
    static Dictionary<int, string> weapons = new Dictionary<int, string>();

    public static void Data()
    {
        //Ship hulls type-#roomSlots-#engineSlots-#weaponSlots
        hulls.Add(0, "basic-2-1-1");
        hulls.Add(10, "small-3-2-2");
        hulls.Add(20, "normal-5-3-4");
        hulls.Add(30, "big-7-4-6");
        //Engines
        engines.Add(0, "basic");
        engines.Add(10, "small");
        engines.Add(20, "normal");
        engines.Add(30, "big");
        //Cockpits
        cockpits.Add(0, "basic");
        cockpits.Add(10, "small");
        cockpits.Add(20, "normal");
        cockpits.Add(30, "big");
        //Weapon Controllers
        weaponControlls.Add(0, "basic");
        weaponControlls.Add(10, "small");
        weaponControlls.Add(20, "normal");
        weaponControlls.Add(30, "big");
        //Weapons
        weapons.Add(0, "basic");
        weapons.Add(10, "small");
        weapons.Add(20, "normal");
        weapons.Add(30, "big");
    }


    public static string GetShip(int level)
    {
        string ship = "";
        


        return ship;
    }

    
}
