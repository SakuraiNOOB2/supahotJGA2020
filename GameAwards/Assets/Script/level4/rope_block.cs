using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope_block : MonoBehaviour
{
    bool player_onblock;
    public Vector3 defaultScale;
    // Start is called before the first frame update
    void Start()
    {
        player_onblock = false;
        defaultScale = transform.lossyScale;
    }

    // Update is called once per frame
    void Update()
    {
        //player_onblock = false;
        Vector3 lossScale = transform.lossyScale;
        Vector3 localScale = transform.localScale;

        transform.localScale = new Vector3(
                localScale.x / lossScale.x * defaultScale.x,
                localScale.y / lossScale.y * defaultScale.y,
                localScale.z / lossScale.z * defaultScale.z
        );
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "concrete")
        {
            player_onblock = true;
            Debug.Log("ropedown");
        }
    }
    public bool PlayerOnBlock()
    {
        return player_onblock;
    }
}
