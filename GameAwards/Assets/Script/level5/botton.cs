using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botton : MonoBehaviour
{
    public bool switch_door;
    // Start is called before the first frame update
    void Start()
    {
        switch_door = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("concrete") || other.CompareTag("Player"))
        {
            switch_door = true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("concrete") || other.CompareTag("Player"))
        {
            switch_door = false;

        }
    }
}
