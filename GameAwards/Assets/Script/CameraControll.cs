using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public subCamera sc;

    private GameObject mainCamera;
    private GameObject subCamera;

    // Start is called before the first frame update
    void Start()
    {
        //カメラを取得
        mainCamera = GameObject.Find("Camera");
        subCamera = GameObject.Find("subCamera");

        //初めにサブカメラでステージ全体を見渡すので、メインカメラを止める。
        mainCamera.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //フラグが切り替わったらカメラも変更して、ゲームスタート
        bool CameraSet;
        CameraSet = sc.GetsubCameraIsOn();

        if(CameraSet==false)
        {
            subCamera.SetActive(false);
            mainCamera.SetActive(true);
        }
    }
}
