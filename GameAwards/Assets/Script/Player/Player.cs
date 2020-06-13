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
    public GameObject Particle;
    // 弾丸発射点
    public Transform muzzle, muzzle2;

    // 弾丸の速度
    public float concrete_speed = 1000;
    
    //アイテム個数
    private int ItemNum;
    private int ItemNumflat;

    private Vector3 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        ItemNum = 0;
        ItemNumflat = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force;

        //スペースを押したら
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown("joystick button 1"))
        {
            switch (inc.GetComponent<ItemNumController>().GetMode())
            {
                //ブロック状のコンクリート
                case 1:
                    if (ol.GetComponent<overlap>().IsNotOverlap() == true && ItemNum != 0)
                    {
                        ItemNum--;
                        // 弾丸の複製
                        GameObject concretes = Instantiate(concrete) as GameObject;
                        
                        force = this.gameObject.transform.forward * concrete_speed;

                        // Rigidbodyに力を加えて発射
                        concretes.GetComponent<Rigidbody>().AddForce(force);

                        // 弾丸の位置を調整
                        concretes.transform.position = muzzle.position;

                        //煙発生
                        GameObject smook = Instantiate(Particle);
                        smook.transform.rotation = transform.rotation;
                        smook.transform.position = muzzle.position;
                    }
                    break;

                //平たいやつ
                case 2:
                    if (ItemNumflat !=0)
                    {
                        ItemNumflat--;
                        // 弾丸の複製
                        GameObject concrete2s = Instantiate(concrete2) as GameObject;

                        force = this.gameObject.transform.forward * concrete_speed;

                        // Rigidbodyに力を加えて発射
                        //concrete2s.GetComponent<Rigidbody>().AddForce(force);

                        // 弾丸の位置を調整
                        concrete2s.transform.position = muzzle2.position;

                        //煙を発生
                        GameObject smook = Instantiate(Particle);
                        smook.transform.rotation = transform.rotation;
                        smook.transform.position = muzzle.position;
                    }
                    break;
            }
        }
    }

    public void AddItem(int Add)
    {
        ItemNum += Add;
    }
    public void AddItemFlat(int Add)
    {
        ItemNumflat += Add;
    }
    public int GetItemNum()
    {
        return ItemNum;
    }
    public int  GetItemNumFlat()
    {
        return ItemNumflat;
    }
}


