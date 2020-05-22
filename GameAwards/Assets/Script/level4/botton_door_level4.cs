using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botton_door_level4 : MonoBehaviour
{
    public GameObject door;
    bool switch_door;
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("door");
        switch_door = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (door.transform.position.y < 20 && !switch_door)
            door.transform.position += transform.up * 0.1f;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("concrete") || other.CompareTag("Player"))
        {
            if (door.transform.position.y > 5)
                door.transform.position -= transform.up * 0.1f;
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
