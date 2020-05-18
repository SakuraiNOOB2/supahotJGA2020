using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static float speed = 0.1f;

    public GameObject inc;
    public GameObject ol;

    // bullet prefab
    public GameObject concrete;
    public GameObject concrete2;
    public GameObject water;
    public GameObject water2;

    // 弾丸発射点
    public Transform muzzle, muzzle2;

    // 弾丸の速度
    public float concrete_speed = 1000;

    private int count = 0;

    private Vector3 moveDirection;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force;

        count++;
        //スペースを押したら
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown("joystick button 1"))
        {
            switch(inc.GetComponent<ItemNumController>().GetMode())
            {
                //ブロック状のコンクリート
                case 1:
                    if(ol.GetComponent<overlap>().IsNotOverlap() == true)
                    {
                        count = 0;
                        // 弾丸の複製
                        GameObject concretes = Instantiate(concrete) as GameObject;

                       

                        force = this.gameObject.transform.forward * concrete_speed;

                        // Rigidbodyに力を加えて発射
                        concretes.GetComponent<Rigidbody>().AddForce(force);

                        // 弾丸の位置を調整
                        concretes.transform.position = muzzle.position;
                    }
                    break;

                //平たいやつ
                case 2:
                    count = 0;
                    // 弾丸の複製
                    GameObject concrete2s = Instantiate(concrete2) as GameObject;

                    force = this.gameObject.transform.forward * concrete_speed;

                    // Rigidbodyに力を加えて発射
                    //concrete2s.GetComponent<Rigidbody>().AddForce(force);

                    // 弾丸の位置を調整
                    concrete2s.transform.position = muzzle2.position;
                    break;
            }
           

        }

        //スペースを押したら
        //if (Input.GetKeyDown(KeyCode.Z) && (inc.GetComponent<ItemNumController>().GetMode() == 1 || inc.GetComponent<ItemNumController>().GetMode() == 2))
        //{

        //    count = 0;
        //    // 弾丸の複製
        //    GameObject waters = Instantiate(water) as GameObject;

        //    Vector3 force;

        //    force = this.gameObject.transform.right * concrete_speed;

        //    // Rigidbodyに力を加えて発射
        //    //waters.GetComponent<Rigidbody>().AddForce(force);

        //    // 弾丸の位置を調整
        //    waters.transform.position = muzzle.position;


        //}
        //if (Input.GetKeyDown(KeyCode.Z) && (inc.GetComponent<ItemNumController>().GetMode() == 1 || inc.GetComponent<ItemNumController>().GetMode() == 2))
        //{

        //    count = 0;
        //    // 弾丸の複製
        //    GameObject water2s = Instantiate(water2) as GameObject;

        //    Vector3 force;

        //    force = this.gameObject.transform.right * concrete_speed;

        //    // Rigidbodyに力を加えて発射
        //    water2s.GetComponent<Rigidbody>().AddForce(force);

        //    // 弾丸の位置を調整
        //    water2s.transform.position = muzzle.position;


        //}
    }
}


