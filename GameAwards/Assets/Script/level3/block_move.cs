using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_move : MonoBehaviour
{

    public int speed;
    int dirx, diry;

    bool movedown;
    // Start is called before the first frame update
    void Start()
    {
        dirx = 5;
        diry = 5;
        movedown = false;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 now = rb.position;

        if (now.x < -14)
            dirx = speed;
        if (now.x > 19)
            dirx = -speed;

        if (now.y > 0 && movedown)
            diry = -1;
        else if (now.y < 10 && !movedown)
            diry = 1;
        else
            diry = 0;

        //now += new Vector3(0.03f * dirx, 0.03f*4/7*diry, 0.0f);
        //rb.position = now;

        transform.Translate(0.03f * dirx, 0.03f  * diry, 0.0f);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "concrete")
        {
            movedown = true;
            Debug.Log("コンクリートが乗った");
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "concrete")
        {
            movedown = false;
            Debug.Log("コンクリートが離れた");
        }
    }
}