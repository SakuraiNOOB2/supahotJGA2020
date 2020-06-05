using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_move_stage5_1 : MonoBehaviour
{
    int dir;
    // Start is called before the first frame update
    void Start()
    {
        dir = -1;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 now = rb.position;

        if (now.y > 8)
            dir = -1;
        if (now.y < 0)
            dir = 1;

        transform.Translate(0.0f, 0.03f * dir, 0.0f);
    }
}
