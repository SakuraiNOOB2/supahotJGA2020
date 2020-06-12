using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemNumController : MonoBehaviour
{
    public int ItemNum;
    int Mode;

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
    public void UseItem()
    {
        ItemNum--;
    }
    // Start is called before the first frame update
    void Start()
    {
        ItemNum = 0;
        Mode = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown("joystick button 2"))
        {
            if (!(ItemNum == 0))
            {
                Mode++;
                if (Mode > 2)
                {
                    Mode = 1;

                }
                
            }

        }
    }
}
