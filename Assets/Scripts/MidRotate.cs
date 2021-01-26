using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidRotate : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 20.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Rotate(0, 0, speed*Time.time,Space.World);
    }
}
