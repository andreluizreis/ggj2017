using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour {

    public Sprite[] energyImages;
    public int maxEnergy = 9; 
    public int currentEnergy = 5; 


	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (currentEnergy < 10 && currentEnergy >= 0)
        {
            GetComponent<SpriteRenderer>().sprite = energyImages[currentEnergy];
        }
	}
}
