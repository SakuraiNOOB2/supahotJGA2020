using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    Animator animator;
    public GameObject door_switch;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("open", false);

        if(door_switch.GetComponent<botton>().switch_door)
        {
            animator.SetBool("open", true);
        }
    }
}
