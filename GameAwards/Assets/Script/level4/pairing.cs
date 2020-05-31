using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pairing : MonoBehaviour
{
    public GameObject pair1, pair2;
    public GameObject pair1block, pair2block;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pair1block.GetComponent<rope_block>().ConcreteOnBlock()&& !pair2block.GetComponent<rope_block>().ConcreteOnBlock())
        {
            pair1.GetComponent<rope>().rope_switch = -1;
            pair2.GetComponent<rope>().rope_switch = 1;
        }
        if (!pair1block.GetComponent<rope_block>().ConcreteOnBlock() && pair2block.GetComponent<rope_block>().ConcreteOnBlock())
        {
            pair1.GetComponent<rope>().rope_switch = 1;
            pair2.GetComponent<rope>().rope_switch = -1;
        }
        if (pair1block.GetComponent<rope_block>().ConcreteOnBlock() && pair2block.GetComponent<rope_block>().ConcreteOnBlock())
        {
            pair1.GetComponent<rope>().rope_switch = 0;
            pair2.GetComponent<rope>().rope_switch = 0;
        }
        if (!pair1block.GetComponent<rope_block>().ConcreteOnBlock() && !pair2block.GetComponent<rope_block>().ConcreteOnBlock())
        {
            pair1.GetComponent<rope>().rope_switch = 2;
            pair2.GetComponent<rope>().rope_switch = 2;
        }

        //if(pair1block.GetComponent<rope_block>().PlayerOnBlock()&& !pair2block.GetComponent<rope_block>().ConcreteOnBlock())
        //{
        //    pair1.GetComponent<rope>().rope_switch = -1;
        //    pair2.GetComponent<rope>().rope_switch = 1;
        //}
        //else if (pair2block.GetComponent<rope_block>().PlayerOnBlock() && !pair1block.GetComponent<rope_block>().ConcreteOnBlock())
        //{
        //    pair2.GetComponent<rope>().rope_switch = -1;
        //    pair1.GetComponent<rope>().rope_switch = 1;
        //}

        //else if (pair1block.GetComponent<rope_block>().PlayerOnBlock() && pair2block.GetComponent<rope_block>().ConcreteOnBlock())
        //{
        //    pair1.GetComponent<rope>().rope_switch = 1;
        //    pair2.GetComponent<rope>().rope_switch = -1;
        //}
        //else if (pair2block.GetComponent<rope_block>().PlayerOnBlock() && pair1block.GetComponent<rope_block>().ConcreteOnBlock())
        //{
        //    pair2.GetComponent<rope>().rope_switch = 1;
        //    pair1.GetComponent<rope>().rope_switch = -1;
        //}

        //else if(pair1block.GetComponent<rope_block>().ConcreteOnBlock()&& !pair2block.GetComponent<rope_block>().PlayerOnBlock())
        //{
        //    pair1.GetComponent<rope>().rope_switch = -1;
        //    pair2.GetComponent<rope>().rope_switch = 1;
        //}
        //else if (pair2block.GetComponent<rope_block>().ConcreteOnBlock() && !pair1block.GetComponent<rope_block>().PlayerOnBlock())
        //{
        //    pair2.GetComponent<rope>().rope_switch = -1;
        //    pair1.GetComponent<rope>().rope_switch = 1;
        //}
        //else
        //{
        //    pair1.GetComponent<rope>().rope_switch = 0;
        //    pair2.GetComponent<rope>().rope_switch = 0;
        //}

    }
}
