using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YesButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NoButtonClicked()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
