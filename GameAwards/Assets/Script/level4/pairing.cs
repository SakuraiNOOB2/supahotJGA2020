using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pairing : MonoBehaviour
{
    public GameObject pair1, pair2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pair1.GetComponent<rope>().rope_switch==-1)
        {
            pair2.GetComponent<rope>().rope_switch = 1;
        }
        if (pair2.GetComponent<rope>().rope_switch == -1)
        {
            pair1.GetComponent<rope>().rope_switch = 1;
        }
    }
}
