using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Image background;
    public Sprite[] seasonList = new Sprite[4];
    private int count = 0;
    
    private float i = 0;

    void Start()
    {
        background.sprite = seasonList[0];
    }

    void Update()
    {
        i += Time.deltaTime;

        if(i >= 1.5f)
        {
            changeSeason();
            i -= 1.5f;
        }
    }
    void changeSeason()
    {
        if (count == 4) 
        {
            count = 0;
        }
        background.sprite = seasonList[count];
        count++;

    }
}
