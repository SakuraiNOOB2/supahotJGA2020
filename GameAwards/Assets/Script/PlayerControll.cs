using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    float jump;      //ジャンプの強さ
    private Vector3 speed;
    private bool jumpflag;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
	    jumpflag =false;
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.transform;
        Vector3 Pos = transform.position;
        Vector3 Rot = this.gameObject.transform.localEulerAngles;
        speed = rb.velocity;
        float dph = Input.GetAxis("D_Pad_H");

        if (Input.GetKey(KeyCode.A) || dph < -0.5f )
        {
            Rot.y = -90;
            Pos.x -= 0.05f;
        }

        if (Input.GetKey(KeyCode.D) || dph > 0.5f)
        {
            Rot.y = 90;
            Pos.x += 0.05f;
        }

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 0"))
        {
	    if(jumpflag ==false)
		{
            rb.AddForce(0,400,0);
		    jumpflag =true;
		}
        }
        transform.position = Pos;
        transform.eulerAngles = Rot;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(speed.y <= 1.0f)
        {
            jumpflag = false;
        }
    }
}

