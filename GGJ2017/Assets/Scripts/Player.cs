using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Animator animator;
    public Animation animation;
    public bool isPlayerOne = true;
    public int currentAnimIndex = 0;

    private string[] animationsNameOne = {"player1_1", "player1_2", "player1_3", "player1_4"};
    private string[] animationsNameTwo = {"player2_1", "player2_2", "player2_3", "player2_4"};

    private string[] animationsNameCurrent;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animation = GetComponent<Animation>();

        animationsNameCurrent = isPlayerOne ? animationsNameOne : animationsNameTwo;
	}
	
	// Update is called once per frame
	void Update () {        
        animator.Play(animationsNameCurrent[currentAnimIndex]);
	}
}
