using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour {

    public SpawnPrey spawner;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
            spawner.numPrey--;
        }
    }
}
