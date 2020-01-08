using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aduio : MonoBehaviour
{
    public AudioClip musicclip;
    public AudioSource musicsource;
    void Start()
    {
        musicsource.clip = musicclip;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
