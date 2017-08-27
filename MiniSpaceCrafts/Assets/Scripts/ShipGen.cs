using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class ShipGen {

    public static Dictionary<int, Hull> hulls = new Dictionary<int, Hull>();
    public static Dictionary<int, Engine> engines = new Dictionary<int, Engine>();
    public static Dictionary<int, Cockpit> cockpits = new Dictionary<int, Cockpit>();
    public static Dictionary<int, Weapon> weapons = new Dictionary<int, Weapon>();
    public static Dictionary<int, Reactor> reactors = new Dictionary<int, Reactor>();
    public static Dictionary<int, MedicBay> medicBays = new Dictionary<int, MedicBay>();
    public static Dictionary<int, Shield> shields = new Dictionary<int, Shield>();
    public static Dictionary<int, RepairShop> repairShops = new Dictionary<int, RepairShop>();

    public static List<Ship> shipPrefabs = new List<Ship>();




    public static void Data()
    {
        if (hulls.Count == 0)
        {

            hulls.Add(0, new Hull(0, "Basic Hull", FType.any, 40, 5));
            hulls.Add(10, new Hull(10, "Steel Hull", FType.any, 50, 10));
            hulls.Add(20, new Hull(20, "Osmium Hull", FType.any, 60, 15));
            hulls.Add(30, new Hull(30, "Tungsten Hull", FType.any, 70, 20));
            hulls.Add(40, new Hull(40, "Chromium Hull", FType.any, 80, 25));



            engines.Add(0, new Engine(0, "Basic Engine", FType.any, 20, 2, 5, 0.15f));
            engines.Add(10, new Engine(10, "Weak Engine", FType.any, 30, 3, 4, 0.25f));
            engines.Add(20, new Engine(20, "Normal Engine", FType.any, 40, 4, 3, 0.35f));
            engines.Add(30, new Engine(30, "Strong Engine", FType.any, 50, 5, 2, 0.45f));
            engines.Add(40, new Engine(40, "Stronger Engine", FType.any, 60, 6, 1, 0.55f));



            cockpits.Add(0, new Cockpit(0, "Basic Cockpit", FType.any, 20, 1));
            cockpits[0].deck.AddRange(new List<Card> { new Card("Evade fire", "Pilots try to evade any incoming fire", 2) } );
            cockpits.Add(10, new Cockpit(10, "Small Cockpit", FType.any, 30, 1));
            cockpits.Add(20, new Cockpit(20, "Big Cockpit", FType.any, 40, 2));
            cockpits.Add(30, new Cockpit(30, "Bigger Cockpit", FType.any, 50, 2));
            cockpits.Add(40, new Cockpit(40, "Large Cockpit", FType.any, 60, 3));



            weapons.Add(0, new Weapon(0, "Basic Laser", FType.any, 7, 10, 2, 0.6f, WType.laser));
            weapons[0].deck.AddRange(new List<Card> { new Card("Laser Shot", "Shoot Basic Laser", 2), new Card("Laser Overcharge", "Overcharges Laser for more damage", 4) });
            weapons.Add(1, new Weapon(0, "Basic Machine Gun", FType.any, 6, 10, 1, 0.4f, WType.kinetic));
            weapons.Add(2, new Weapon(0, "Basic Missile Launcher", FType.any, 4, 10, 1, 1f, WType.missile));

            weapons.Add(10, new Weapon(10, "Weak Laser", FType.any, 9, 20, 2, 0.6f, WType.laser));
            weapons[10].deck.AddRange(new List<Card> { new Card("Laser Shot", "Shoot Weak Laser", 3), new Card("Laser Overcharge", "Overcharges Laser for more damage", 5) });
            weapons.Add(11, new Weapon(10, "Small Machine Gun", FType.any, 8, 20, 1, 0.4f, WType.kinetic));
            weapons.Add(12, new Weapon(10, "Small Missile Launcher", FType.any, 6, 20, 1, 1f, WType.missile));

            weapons.Add(20, new Weapon(20, "Strong Laser", FType.any, 11, 30, 3, 0.6f, WType.laser));
            weapons[20].deck.AddRange(new List<Card> { new Card("Laser Shot", "Shoot Strong Laser", 4), new Card("Laser Overcharge", "Overcharges Laser for more damage", 6) });
            weapons.Add(21, new Weapon(20, "Bigg Machine Gun", FType.any, 10, 30, 2, 0.4f, WType.kinetic));
            weapons.Add(22, new Weapon(20, "Bigg Missile Launcher", FType.any, 8, 30, 2, 1f, WType.missile));

            weapons.Add(30, new Weapon(30, "Stronger Laser", FType.any, 13, 40, 3, 0.6f, WType.laser));
            weapons[30].deck.AddRange(new List<Card> { new Card("Laser Shot", "Shoot Stronger Laser", 5), new Card("Laser Overcharge", "Overcharges Laser for more damage", 7) });
            weapons.Add(31, new Weapon(30, "Bigger Machine Gun", FType.any, 12, 40, 2, 0.4f, WType.kinetic));
            weapons.Add(32, new Weapon(30, "Bigger Missile Launcher", FType.any, 10, 40, 2, 1f, WType.missile));

            weapons.Add(40, new Weapon(40, "Powerful Laser", FType.any, 15, 50, 4, 0.6f, WType.laser));
            weapons[40].deck.AddRange(new List<Card> { new Card("Laser Shot", "Shoot Powerful Laser", 6), new Card("Laser Overcharge", "Overcharges Laser for more damage", 8) });
            weapons.Add(41, new Weapon(40, "Large Machine Gun", FType.any, 14, 50, 3, 0.4f, WType.kinetic));
            weapons.Add(42, new Weapon(40, "Large Missile Launcher", FType.any, 12, 50, 3, 1f, WType.missile));



            reactors.Add(0, new Reactor(0, "Basic Reactor", FType.any, 20, 8));
            reactors.Add(10, new Reactor(10, "Weak Reactor", FType.any, 30, 10));
            reactors.Add(20, new Reactor(20, "Normal Reactor", FType.any, 40, 12));
            reactors.Add(30, new Reactor(30, "Strong Reactor", FType.any, 50, 14));
            reactors.Add(40, new Reactor(40, "Stronger Reactor", FType.any, 60, 16));



            medicBays.Add(20, new MedicBay(20, "Basic Medic Bay", FType.any, 20, 0.25f));
            medicBays.Add(30, new MedicBay(30, "Small Medic Bay", FType.any, 20, 0.35f));
            medicBays.Add(40, new MedicBay(40, "Normal Medic Bay", FType.any, 20, 0.45f));
            medicBays.Add(50, new MedicBay(50, "Big Medic Bay", FType.any, 20, 0.55f));



            shields.Add(20, new Shield(20, "Basic Shield", FType.any, 10, 1, 1, 2));
            shields.Add(30, new Shield(30, "Weak Shield", FType.any, 20, 1, 1, 2));
            shields.Add(40, new Shield(40, "Normal Shield", FType.any, 15, 2, 1, 2));
            shields.Add(50, new Shield(50, "Strong Shield", FType.any, 25, 2, 2, 2));
            shields.Add(60, new Shield(60, "Stronger Shield", FType.any, 20, 3, 1, 2));



            repairShops.Add(20, new RepairShop(20, "Basic Repair Shop", FType.any, 20, 0.25f));
            repairShops.Add(30, new RepairShop(30, "Small Repair Shop", FType.any, 20, 0.35f));
            repairShops.Add(40, new RepairShop(40, "Normal Repair Shop", FType.any, 20, 0.45f));
            repairShops.Add(50, new RepairShop(50, "Big Repair Shop", FType.any, 20, 0.55f));
        }
    }


    public static Ship GetShip(int level, FType type)
    {
        Ship ship = new Ship(2 + Mathf.RoundToInt(Random.Range(0.08f, 0.12f) * level), 2 + Mathf.RoundToInt(Random.Range(0.06f, 0.08f) * level), 2 + Mathf.RoundToInt(Random.Range(0.06f, 0.08f) * level), +Mathf.RoundToInt(Random.Range(0.04f, 0.06f) * level));

        ship.Hull = GetHull(level, type);
        ship.Cockpit = GetCockpit(level, type);
        ship.Reactors.Add((Reactor)ship.PlaceRoomToRandomPos(GetReactor(level, type)));

        return ship;
    }

    public static Hull GetHull(int level, FType type)
    {
        Data();
        for (int i = level + 9; i >= 0; i--)
        {
            if (hulls.ContainsKey(i) && (hulls[i].type == type) || hulls[i].type == FType.any)
            {
                return hulls[i];
            }
        }
        return hulls[0];
    }

    public static Engine GetEngine(int level, FType type)
    {
        Data();
        for (int i = level + 9; i >= 0; i--)
        {
            if (engines.ContainsKey(i) && (engines[i].type == type) || engines[i].type == FType.any)
            {
                return engines[i];
            }
        }
        return engines[0];
    }

    public static Reactor GetReactor(int level, FType type)
    {
        Data();
        for (int i = level + 9; i >= 0; i--)
        {
            if (reactors.ContainsKey(i) && (reactors[i].type == type) || reactors[i].type == FType.any)
            {
                return reactors[i];
            }
        }
        return reactors[0];
    }

    public static Cockpit GetCockpit(int level, FType type)
    {
        Data();
        for (int i = level + 9; i >= 0; i--)
        {
            if (cockpits.ContainsKey(i) && (cockpits[i].type == type) || cockpits[i].type == FType.any)
            {
                return cockpits[i];
            }
        }
        return cockpits[0];
    }

    public static Weapon GetWeapon(int level, FType fType, WType wType)
    {
        Data();
        int offset = 0;
        if (wType == WType.any)
        {
            offset = Random.Range(0, 2);
        }
        else if (wType == WType.kinetic)
        {
            offset = 1;
        }
        else if (wType == WType.missile)
        {
            offset = 2;
        }
        for (int i = level + offset; i >= 0; i--)
        {
            if (weapons.ContainsKey(i) && (weapons[i].type == fType || weapons[i].type == FType.any) && (weapons[i].weaponType == wType || weapons[i].weaponType == WType.any))
            {
                return weapons[i];
            }
        }
        return weapons[0];
    }

    public static Shield GetShield(int level, FType type)
    {
        Data();
        for (int i = level + 9; i >= 0; i--)
        {
            if (shields.ContainsKey(i) && (shields[i].type == type) || shields[i].type == FType.any)
            {
                return shields[i];
            }
        }
        return null;
    }

    public static MedicBay GetMedicBay(int level, FType type)
    {
        Data();
        for (int i = level + 9; i >= 0; i--)
        {
            if (medicBays.ContainsKey(i) && (medicBays[i].type == type) || medicBays[i].type == FType.any)
            {
                return medicBays[i];
            }
        }
        return null;
    }

    public static RepairShop GetRepairShop(int level, FType type)
    {
        Data();
        for (int i = level + 9; i >= 0; i--)
        {
            if (repairShops.ContainsKey(i) && (repairShops[i].type == type) || repairShops[i].type == FType.any)
            {
                return repairShops[i];
            }
        }
        return null;
    }
}
