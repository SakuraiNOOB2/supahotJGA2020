using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dpv = Input.GetAxis("D_Pad_V");
        float dph = Input.GetAxis("D_Pad_H");
        Vector3 Pos = transform.position;

        Pos.x = Pos.x + dph / 100;
        Pos.y = Pos.y + dpv / 100;

        transform.position = Pos;
    }
}
