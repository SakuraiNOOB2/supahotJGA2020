using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messagecollider : MonoBehaviour
{
    public GameObject Message;
    // Start is called before the first frame update
    void Start()
    {
        Message.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("message1 out");
            Message.SetActive(false);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("message1 in");
            Message.SetActive(true);
        }
    }

}
