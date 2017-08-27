using UnityEngine;
using System.Collections;
using TMPro;

public class GameLoop : MonoBehaviour {

    public bool isRunning = true;
    

    Ship ship;
    

	void Start () {
        ShipGen.Data();

        ship = new Ship(5, 3, 2, 1);
        ship.Hull = new Hull(0, "basic", FType.any, 100, 10);
        ship.AddWeapon(ShipGen.GetWeapon(0, FType.any, WType.laser));
        ship.AddWeapon(ShipGen.GetWeapon(0, FType.any, WType.kinetic));
        ship.AddEngine(new Engine(0, "Basic Engine", FType.any, 0, 2, 5, 0.15f));

	}

    void Update()
    {

    }
    

}
