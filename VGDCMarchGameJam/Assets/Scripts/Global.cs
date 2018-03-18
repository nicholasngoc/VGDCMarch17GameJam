using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour {

    public int numEaten = 0;
    public int eatGoal = 15;
    public bool mature = false;
    public SpawnPrey spawner;
    public GameObject angler;
    public int maxSpawn;

    int spawnCount;
	
	// Update is called once per frame
	void Update () {
		
        if(numEaten >= eatGoal)
        {
            mature = true;
            if (spawnCount < maxSpawn)
            {
                spawner.spawnPrey(angler);
            }
        }

	}

}
