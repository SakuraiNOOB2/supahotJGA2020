using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messagecollider2 : MonoBehaviour
{
    public Text MessageCollider2Text;
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
            Debug.Log("message2 out");
            MessageCollider2Text.text = null;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("message2 in");
            MessageCollider2Text.text = "橋を作って渡ろう";
        }
    }

}
