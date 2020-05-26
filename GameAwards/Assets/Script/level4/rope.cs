using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour
{
    public int rope_switch;//-1下,1上,0停止
    public GameObject block;
    public Vector3 length;
    public Vector3 maxlength;
    public Vector3 minlength;
    // Start is called before the first frame update
    void Start()
    {
        rope_switch = 0;
        length = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
       
        length = transform.localScale;

        if (rope_switch == -1)
        {
            
            if (length.y < maxlength.y)
            {
                length.y += 0.01f;
            }
            else
            {
                rope_switch = 0;
            }
        }
        if (rope_switch == 1)
        {

            if (length.y > minlength.y)
            {
                length.y -= 0.01f;
            }
            else
            {
                rope_switch = 0;
            }
        }
        transform.localScale = new Vector3(length.x, length.y, length.z);

    }



public int RopeSwithsIsOn()
    {
        return rope_switch;
    }
}
