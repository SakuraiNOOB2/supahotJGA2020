using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botton_block_stage5_1 : MonoBehaviour
{
    public GameObject block;
    bool switch_block;
    // Start is called before the first frame update
    void Start()
    {
        block = GameObject.Find("moveblock_botton1");
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("concrete")&& block.transform.position.y < 8)
        {
            block.transform.position += transform.up * 0.1f;
            
        }
    }
}
