using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class item : MonoBehaviour
{
    private GameObject Player;
    public GameObject inc; // エディターから取得できるようにpublicにしておく

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //回転させる
        transform.Rotate(new Vector3(0, 1, 0));
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ぶつかった");
            inc.GetComponent<ItemNumController>().AddItemNum(1);
            gameObject.SetActive(false);
        }
    }
}
