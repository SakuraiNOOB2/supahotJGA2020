using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    float jump;      //ジャンプの強さ
    private Vector3 speed;
    private bool jumpflag;
    private bool breakfrag;
    public Rigidbody rb;
    public GameObject maincamera;
    public GameObject subcamera;
    Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        jumpflag =false;
        breakfrag = false;
    }

    // Update is called once per frame
    void Update()
    {
        //　pause用
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        Transform transform = this.transform;
        Vector3 Pos = transform.position;
        Vector3 Rot = this.gameObject.transform.localEulerAngles;
        speed = rb.velocity;
        float dph = Input.GetAxis("Horizontal");
        _animator.SetBool("isRun", false);

        if (Input.GetKey(KeyCode.A) || dph < -0.5f )
        {
            Rot.y = -90;
            Pos.x -= 0.05f;
            _animator.SetBool("isRun", true);
        }

        if (Input.GetKey(KeyCode.D) || dph > 0.5f)
        {
            Rot.y = 90;
            Pos.x += 0.05f;
            _animator.SetBool("isRun", true);
        }

        if (Input.GetKey("joystick button 3"))
        {
            maincamera.SetActive(false);
            subcamera.SetActive(true);
        }
        else
        {
            subcamera.SetActive(false);
            maincamera.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 0"))
        {
	    if(jumpflag ==false)
		{
            rb.AddForce(0,400,0);
		    jumpflag =true;
		}
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            breakfrag = true;
        }

        if(Input.GetKeyUp(KeyCode.X))
        {
            breakfrag = false;
        }
        transform.position = Pos;
        transform.eulerAngles = Rot;

        if(jumpflag == true)
        {
            _animator.SetBool("isRun", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(speed.y <= 1.0f)
        {
            jumpflag = false;
        }
        if (breakfrag ==true)
        {
            if (collision.gameObject.name == ("concrete1_freezed(Clone)"))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}

