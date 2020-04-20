using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    float jump;     //ジャンプの強さ
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.transform;
        Vector3 Pos = transform.position;
        Vector3 Rot = this.gameObject.transform.localEulerAngles;

        if (Input.GetKey(KeyCode.A))
        {
            Rot.y = -90;
            Pos.x -= 0.05f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Rot.y = 90;
            Pos.x += 0.05f;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0,400,0);
        }
        transform.position = Pos;
        transform.eulerAngles = Rot;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}

