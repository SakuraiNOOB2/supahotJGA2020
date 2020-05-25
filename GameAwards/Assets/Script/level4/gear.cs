using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear : MonoBehaviour
{
    public float direction;//+:時計回り,-:逆時計回り
    public GameObject obj_rope;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (obj_rope.GetComponent<rope>().RopeSwithsIsOn() == 1)
        {
            transform.Rotate(new Vector3(0, 0, direction));
        }
        if (obj_rope.GetComponent<rope>().RopeSwithsIsOn() == -1)
        {
            transform.Rotate(new Vector3(0, 0, -direction));
        }
    }
}
