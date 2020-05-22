using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField]
    GameObject Fade;

    bool Use;
    // Start is called before the first frame update
    void Start()
    {
        Use = true;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Use == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 7"))
            {
                Fade.GetComponent<Fade>().SetMode(1);
                Use = false;
            }
        }
        else
        {
            if (Fade.GetComponent<Fade>().GetFadeStart() == false)
            {
                SceneManager.LoadScene("StageSelect");
            }
        }
    }
}
