using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemNumController : MonoBehaviour
{
    public int ItemNum;
    int Mode;
    public Text ItemText;

    public void AddItemNum(int i)
    {
        ItemNum += i;
    }
    public int GetItemNum()
    {
        return ItemNum;
    }
    public int GetMode()
    {
        return Mode;
    }
    // Start is called before the first frame update
    void Start()
    {
        ItemNum = 0;
        Mode = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(!(ItemNum == 0))
            {
                Mode++;
                if (Mode > ItemNum)
                    Mode = 1;
            }

        }

        ItemText.text = "MODE:" + Mode.ToString();
    }
}
