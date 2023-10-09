using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Timer : MonoBehaviour
{
    public TMP_Text textTimer;
    public float time = 0f;
    public GameObject panel;
    public AudioSource FX;
    // Start is called before the first frame update
    void Start()
    {
        textTimer.text = "inicio cambio :)";
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        textTimer.text = time.ToString();
        if (time > 30)
        {
            panel.SetActive(true);
            
        }
    }
}
