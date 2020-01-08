using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceControl : MonoBehaviour
{
    public String[] input;
    public movement player;
    public background bg;
    public breadaction bread;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    public AudioClip musicclip;
    public AudioSource musicsource;
    private void Start()
    {
        musicsource.clip = musicclip;
        actions.Add("left", left);
        actions.Add("right", right);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void left()
    {
        musicsource.Play();
        player.playeranimation.SetBool("detect", true);
        bg.scroll_speed = 0f;
        bread.go.SetActive(true);
        bread.speed = 5f;
    }

    private void right()
    {
        //player.position += new Vector3(50f, 0, 0);
        transform.Translate(1, 0, 0);
    }
}