using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    private bool Clear;
    private int time;

    [SerializeField]
    private Text UnkoText;

    [SerializeField]
    private GameObject ItemControll;

    // Start is called before the first frame update
    void Start()
    {
        Clear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Clear==true)
        {
            float alfa = 1.0f;
            float red = UnkoText.gameObject.GetComponent<Text>().color.r;
            float green = UnkoText.gameObject.GetComponent<Text>().color.g;
            float blue = UnkoText.gameObject.GetComponent<Text>().color.b;

            UnkoText.gameObject.GetComponent<Text>().color = new Color(red, green, blue, alfa);

            time++;
        }

        if(time >=300)
        {
            //フェード付きで選択画面に戻る
            ItemControll.GetComponent<SceneController>().NoButtonClicked();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ThirdPersonController")
        {
            Clear = true;
        }
    }

    public bool GetClear()
    {
        return Clear;
    }
}