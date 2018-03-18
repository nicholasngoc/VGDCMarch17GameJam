using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour {

    public Text theText;
    public Global global;

    private void Update()
    {
        Debug.Log(global.numEaten);
        if(global.numEaten == global.eatGoal)
        {
            Debug.Log("worked");
            theText.enabled = true;
        }
    }
}
