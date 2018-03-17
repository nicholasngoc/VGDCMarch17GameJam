using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrey : MonoBehaviour {

    public int spawnCount;
    public int numPrey;
    public GameObject[] prey;
    public GameObject environment;
    public float respawnRate;

    float currentTime;

    private void Awake()
    {
        currentTime = 0f;
        numPrey = 0;
    }

    void Update () {
        
        if(currentTime > respawnRate && numPrey < spawnCount)
        {
            spawnPrey();
            numPrey++;
            currentTime = 0f;
        }
        else
        {
            currentTime += Time.deltaTime;
        }
	}

    void spawnPrey()
    {
        Vector3 ranPosition = new Vector3(Random.Range(environment.transform.position.x - environment.transform.lossyScale.x / 2, environment.transform.position.x + environment.transform.lossyScale.x / 2),
            Random.Range(environment.transform.position.y - environment.transform.lossyScale.y / 2, environment.transform.position.y + environment.transform.lossyScale.y / 2),
            Random.Range(environment.transform.position.z - environment.transform.lossyScale.z / 2, environment.transform.position.z + environment.transform.lossyScale.z / 2));
        //Debug.Log(ranPosition);

        Quaternion ranRotation = Random.rotation;

        int ranPrey = Random.Range(0, prey.Length - 1);

        Instantiate(prey[ranPrey], ranPosition, ranRotation);
    }
}
