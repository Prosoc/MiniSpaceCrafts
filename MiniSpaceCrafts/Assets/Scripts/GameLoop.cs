using UnityEngine;
using System.Collections;
using TMPro;

public class GameLoop : MonoBehaviour {

    public bool isRunning = true;
    

    Ship ship;
    

	void Start () {
        ship = new Ship(new Hull("basic", "asd", 0, 100, 10), 5, 3, 2);
        ship.AddWeapon(new Weapon("Small Laser", "small_laser", 10, 0, 1));
        ship.AddWeapon(new Weapon("Large Laser", "large_laser", 10, 20, 3));
        ship.AddEngine(new Engine());

	}

    void Update()
    {

    }

    public void Shoot()
    {
        if (ship != null)
        {
            ship.ShootWeapons();
        }
    }

    public void MoveToSelectedPos()
    {

    }

    public void LoopN()
    {
        EventHandler.OnLoopFunctions();
    }

}
