using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBallScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        rb.AddForce(new Vector3(hor * speed, 0f, ver * speed));
        //rb.AddForce(Vector3.forward*speed);
    }
}
