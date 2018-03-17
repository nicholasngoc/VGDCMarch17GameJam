using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public string direction;
    public float margin;

    private void OnCollisionEnter(Collision collision)
    {
        if(direction.Equals("N"))
        {
            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -(this.gameObject.transform.position.z) + margin);
        }
        if (direction.Equals("S"))
        {
            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -(this.gameObject.transform.position.z) - margin);
        }
        if (direction.Equals("W"))
        {
            collision.gameObject.transform.position = new Vector3(-(this.gameObject.transform.position.x) - margin, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
        }
        if (direction.Equals("E"))
        {
            collision.gameObject.transform.position = new Vector3(-(this.gameObject.transform.position.x) + margin, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
        }
        if (direction.Equals("T"))
        {
            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x, -(this.gameObject.transform.position.y) + margin, collision.gameObject.transform.position.z);
        }
        if (direction.Equals("B"))
        {
            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x, -(this.gameObject.transform.position.y) - margin, collision.gameObject.transform.position.z);
        }
    }
}
