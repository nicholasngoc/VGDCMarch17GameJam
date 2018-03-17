using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour {

    public Transform playerTransform;
    public float smoothTime;
    public float targetDistance;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Follow(other.transform));
    }

    IEnumerator Follow(Transform target)
    {
        while (transform.position != target.position)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(
                         target.position.x - (transform.forward.x * targetDistance),
                         target.position.y,
                         target.position.z - (transform.forward.z * targetDistance)
                         ),
                         Time.deltaTime * smoothTime);
        }
        return null;

    }
}
