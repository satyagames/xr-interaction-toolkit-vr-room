using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPositionReset : MonoBehaviour
{
    private Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawner")
        {
            Respawn();
        }
    }
    private void Respawn()
    {
        transform.position = startPos;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        Debug.Log(gameObject.name + " respawned");
    }
}
