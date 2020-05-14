using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {

    //　トータル制限時間
    private float totalTime;
    //　制限時間（分）
    [SerializeField]
    private int minute;
    //　制限時間（秒）
    [SerializeField]
    private float seconds;
    //　開始待ち
    [SerializeField]
    private int startwait;
    //　前回Update時の秒数
    private float oldSeconds;
    private Text timerText;

    int wait = 0;

    //BGM
    public AudioClip MainBGM;


    private AudioSource audioSource;

    bool flag;

    void Start()
    {
        totalTime = minute * 60 + seconds;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();

        //音楽
        audioSource = gameObject.GetComponent<AudioSource>();

        flag = false;
    }

    void Update()
    {
        //BGM再生
        if (wait >= startwait && flag == false)
        {
            flag = true;
            audioSource.PlayOneShot(MainBGM);
        }

        if (wait < startwait)
        {
            wait++;
        }
        else if (wait >= startwait)
        {
            //　制限時間が0秒以下なら何もしない
            if (totalTime <= 0f)
            {
                return;
            }
            //　一旦トータルの制限時間を計測；
            totalTime = minute * 60 + seconds;
            totalTime -= Time.deltaTime;

            //　再設定
            minute = (int)totalTime / 60;
            seconds = totalTime - minute * 60;

            //　タイマー表示用UIテキストに時間を表示する
            if ((int)seconds != (int)oldSeconds)
            {
                timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
            }
            oldSeconds = seconds;
            //  時間が0になったらシーン移行
            if (totalTime <= 0f)
            {
                SceneManager.LoadScene("finish");
            }
        }
    }
}
