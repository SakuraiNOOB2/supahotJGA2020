using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzzle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform MyTransform = this.transform;

        Vector3 pos = MyTransform.position;

        if (Input.GetKey(KeyCode.L))
        {
            pos.x += 0.05f;
        }

        if (Input.GetKey(KeyCode.J))
        {
            pos.x -= 0.05f;
        }

        if (Input.GetKey(KeyCode.U))
        {
            pos.y += 0.05f;
        }

        if (Input.GetKey(KeyCode.O))
        {
            pos.y -= 0.05f;
        }

        MyTransform.position = pos;
        pos.x = 0;
    }
}
