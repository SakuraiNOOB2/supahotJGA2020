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

        Pos.x = Pos.x + dph * 5;
        Pos.y = Pos.y + dpv * 5;

        transform.position = Pos;

        if (Input.GetKeyDown("joystick button 0"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Pos);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                SceneManager.LoadScene(hit.collider.gameObject.name);
            }
        }
    }
}
