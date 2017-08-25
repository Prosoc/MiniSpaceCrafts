using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour {

    TextMeshProUGUI cardName;
    TextMeshProUGUI cardDescription;

    // Use this for initialization
    void Start () {
        foreach (TextMeshProUGUI t in GetComponentsInChildren<TextMeshProUGUI>())
        {
            if (t.name == "name")
            {
                cardName = t;
            }
            else if (t.name == "description")
            {
                cardDescription = t;
            }
        }

        cardName.text = "small laser shot";
        cardDescription.text = "Your laser weapons shoot at the enemy ship's " + "Engines" + "\n\nUses: " + "1" + " energy.";

    }
	
    
	// Update is called once per frame
	void Update () {
	
	}
}
