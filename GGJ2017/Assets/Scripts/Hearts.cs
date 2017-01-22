using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour {
    	
	public Sprite[] heartImages;
    public int currentHeart = 3; 


    void Start(){
        
	}
	

	void Update() {
        if (currentHeart < 7 && currentHeart >= 0)
        {
            GetComponent<SpriteRenderer>().sprite = heartImages[currentHeart];
        }
	}

}
