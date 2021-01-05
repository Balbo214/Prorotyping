using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    private CameraTest cameraTest;
    private void Awake()
    {
        cameraTest = FindObjectOfType<CameraTest>();
    }
    public void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Car") == true)
        {
            obj.GetComponent<PlayerMovement>().enabled = true;
            obj.GetComponent<AIBehaviour>().enabled = false;
            cameraTest.target = obj.transform;
            this.GetComponent<PlayerMovement>().enabled = false;
            this.GetComponent<AIBehaviour>().enabled = true;
        }
    }
}
