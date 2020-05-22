using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cursor : MonoBehaviour
{
    bool Use;       //使用
    bool Out;       //シーン抜け出すときに使う
    string Name;
    [SerializeField]
    GameObject Fade;

    // Start is called before the first frame update
    void Start()
    {
        Out = false;
        Use = false;
        Fade.GetComponent<Fade>().SetMode(2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Use==true)
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
                    Name = hit.collider.gameObject.name;
                    Use = false;
                    Out = true;
                    Fade.GetComponent<Fade>().SetMode(1);
                }
            }
        }
        else
        {
            if(Fade.GetComponent<Fade>().GetFadeStart() == false)
            {
                if (Out == true)
                {
                    SceneManager.LoadScene(Name);
                }
                Use = true;
            }
        }

    }
}
