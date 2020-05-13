using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_move : MonoBehaviour
{
    int dirx,diry;
    // Start is called before the first frame update
    void Start()
    {
        dirx = 1;
        diry = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 now = rb.position;

        if (now.x < -20)
            dirx = 1;
        if (now.x > 15)
            dirx = -1;

        if (now.y > 20)
            diry = -1;
        if (now.y < 0)
            diry = 1;

        now += new Vector3(0.03f * dirx, 0.03f*4/7*diry, 0.0f);
        rb.position = now;
    }
}