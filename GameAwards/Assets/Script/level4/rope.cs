using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour
{
    bool switch_on;
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        switch_on = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch_on = block.GetComponent<rope_block>().PlayerOnBlock();
        if (switch_on)
        {
            Vector3 scale = transform.localScale;
            scale.y += 0.01f;
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        }
        
    }

    public bool RopeSwithsIsOn()
    {
        return switch_on;
    }
}
