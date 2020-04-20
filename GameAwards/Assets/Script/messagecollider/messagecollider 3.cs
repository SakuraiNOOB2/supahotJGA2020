using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messagecollider : MonoBehaviour
{
    public Text MessageCollider1Text;
    // Start is called before the first frame update
    void Start()
    {
      
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
            MessageCollider1Text.text = null;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("message1 in");
            MessageCollider1Text.text = "階段を作ってジャンプしてみよう";
        }
    }

}
