using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class ShipGen {

    static Dictionary<int, Hull> hulls = new Dictionary<int, Hull>();
    static Dictionary<int, Engine> engines = new Dictionary<int, Engine>();
    static Dictionary<int, Cockpit> cockpits = new Dictionary<int, Cockpit>();
    static Dictionary<int, Weapon> weapons = new Dictionary<int, Weapon>();
    static Dictionary<int, Reactor> reactors = new Dictionary<int, Reactor>();


    public static void Data()
    {
        hulls.Add(0, new Hull("Basic Hull", "any", 0, 10, 5));
        hulls.Add(10, new Hull("Iron Hull", "any", 10, 20, 10));
        hulls.Add(20, new Hull("Steel Hull", "any", 20, 30, 15));
        hulls.Add(30, new Hull("Charbon Fibre Hull", "any", 30, 40, 20));
        hulls.Add(40, new Hull("Strong Hull", "any", 40, 50, 25));

        engines.Add(0, new Engine());
    }


    public static Ship GetShip(int level)
    {
        Ship ship = new Ship();
        


        return ship;
    }

    
}
