using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope_block : MonoBehaviour
{
    bool player_onblock;
    bool concrete_onblock;
    Vector3 defaultScale;
    // Start is called before the first frame update
    void Start()
    {
        player_onblock = false;
        concrete_onblock = false;
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
        if (other.gameObject.tag == "Player")
        {
            player_onblock = true;
        }
        if(other.gameObject.tag == "concrete")
        {
            concrete_onblock = true;
        }
    }
    public bool PlayerOnBlock()
    {
        return player_onblock;
    }
    public bool ConcreteOnBlock()
    {
        return concrete_onblock;
    }
}
