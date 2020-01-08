using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class read : MonoBehaviour
{
    // Start is called before the first frame update
    public List<string> list;
    //public string[] list = new string[21];
    private int count = 0;
    void Start()
    {
        
        ReadCSVFile();
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i]);
            
        }
        
    }

    // Update is called once per frame
    void ReadCSVFile() 
    {

        StreamReader strReader = new StreamReader("C:/Users/phiis/Desktop/Sheng/prototype/Assets/Scenes/default.csv");
       
        bool endOfFile = false;
        while (!endOfFile) 
        {
            string data_String = strReader.ReadLine();
            if (data_String == null)
            {
                endOfFile = true;
                break;
            }
            var DATA = data_String.Split(',');
            
           /* for (int i = 0; i < DATA.Length; i++)
             {
            Debug.Log(DATA[i].ToString());
            list[i] = DATA[i].ToString();
              }*/
            //Debug.Log(DATA[0].ToString());
            list.Add(DATA[0].ToString());
            count++;
            
        }
        
    }
}
