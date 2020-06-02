using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    private bool Clear;         //ゴールにたどり着いたか
    private int time;           //待機時間

    [SerializeField]
    private Text UnkoText;      //Clear文字

    [SerializeField]
    private GameObject ItemControll;

    [SerializeField]
    private GameObject Particle;      //パーティクル

    // Start is called before the first frame update
    void Start()
    {
        Clear = false;
        time = 0;
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
            if(Clear == false)
            {
                Instantiate(Particle,new Vector3(transform.position.x + 5, transform.position.y + 1, transform.position.z + 5), new Quaternion(0, 0, 0, 0)); //パーティクル用ゲームオブジェクト生成
                Instantiate(Particle, new Vector3(transform.position.x + 5, transform.position.y + 1, transform.position.z - 5), new Quaternion(0, 0, 0, 0)); //パーティクル用ゲームオブジェクト生成
                Instantiate(Particle, new Vector3(transform.position.x - 5, transform.position.y + 1, transform.position.z + 5), new Quaternion(0, 0, 0, 0)); //パーティクル用ゲームオブジェクト生成
                Instantiate(Particle, new Vector3(transform.position.x - 5, transform.position.y + 1, transform.position.z - 5), new Quaternion(0, 0, 0, 0)); //パーティクル用ゲームオブジェクト生成
            }
            Clear = true;
        }
    }

    public bool GetClear()
    {
        return Clear;
    }
}