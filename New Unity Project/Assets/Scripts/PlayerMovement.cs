using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontal;
    float vertical;
    public float speed = 5.0f;
    //public Transform target;

    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }
}
