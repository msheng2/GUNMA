using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BUTTON : MonoBehaviour
{

    public GameObject panel;
    public health life;
    public Text word;
    // Start is called before the first frame update
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void Update()
    {  
        if (life.hp < 1)
        {
            word.text = "";
            panel.gameObject.SetActive(true);
        }
    }
}
