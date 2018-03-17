using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Worms_Eaten_Display : MonoBehaviour {

    public Text myText2;
    public Global global;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        myText2.text = "worms eaten: " + global.numEaten;
	}
}
