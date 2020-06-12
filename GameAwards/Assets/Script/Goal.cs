using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    private bool Clear;         //�S�[���ɂ��ǂ蒅������
    private bool koolfade;
    private int time;           //�ҋ@����

    [SerializeField]
    private Text UnkoText;      //Clear����

    [SerializeField]
    private GameObject ItemControll;

    [SerializeField]
    private GameObject Particle;      //�p�[�e�B�N��

    [SerializeField]
    private GameObject Fade;

    // Start is called before the first frame update
    void Start()
    {
        koolfade = false;
        Clear = false;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Clear == true)
        {
            float alfa = 1.0f;
            float red = UnkoText.gameObject.GetComponent<Text>().color.r;
            float green = UnkoText.gameObject.GetComponent<Text>().color.g;
            float blue = UnkoText.gameObject.GetComponent<Text>().color.b;

            UnkoText.gameObject.GetComponent<Text>().color = new Color(red, green, blue, alfa);

            time++;
        }

        if (time >= 300)
        {
            //�N���A�t���O�����Ă�(�͋Z)
            if (SceneManager.GetActiveScene().name == "Stage 1")
            {   //�X�e�[�W1
                PlayerPrefs.SetInt("Cleard" + 0, 1);
            }
            if (SceneManager.GetActiveScene().name == "Stage 2")
            {   //�X�e�[�W2
                PlayerPrefs.SetInt("Cleard" + 1, 1);
            }
            if (SceneManager.GetActiveScene().name == "Stage 3")
            {   //�X�e�[�W3
                PlayerPrefs.SetInt("Cleard" + 2, 1);
            }
            if (SceneManager.GetActiveScene().name == "Stage 4")
            {   //�X�e�[�W4
                PlayerPrefs.SetInt("Cleard" + 3, 1);
            }
            if (SceneManager.GetActiveScene().name == "Stage 5")
            {   //�X�e�[�W5
                PlayerPrefs.SetInt("Cleard" + 4, 1);
            }
            //�t�F�[�h�t���őI����ʂɖ߂�
            if (koolfade == false)
            {
                Fade.GetComponent<Fade>().SetMode(1);
                koolfade = true;
            }
            if (Fade.GetComponent<Fade>().GetFadeStart() == false)
            {//�����ꂽ�{�^���ŕς���
                SceneManager.LoadScene("StageSelect");
            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ThirdPersonController")
        {
            if(Clear == false)
            {
                Instantiate(Particle,new Vector3(transform.position.x + 5, transform.position.y + 1, transform.position.z + 5), new Quaternion(0, 0, 0, 0)); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����
                Instantiate(Particle, new Vector3(transform.position.x + 5, transform.position.y + 1, transform.position.z - 5), new Quaternion(0, 0, 0, 0)); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����
                Instantiate(Particle, new Vector3(transform.position.x - 5, transform.position.y + 1, transform.position.z + 5), new Quaternion(0, 0, 0, 0)); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����
                Instantiate(Particle, new Vector3(transform.position.x - 5, transform.position.y + 1, transform.position.z - 5), new Quaternion(0, 0, 0, 0)); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����
            }
            Clear = true;
        }
    }

    public bool GetClear()
    {
        return Clear;
    }
}