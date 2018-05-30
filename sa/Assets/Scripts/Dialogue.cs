﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

    public GameObject panel;
    private Text _textcom;
    public string[] dialoguestring;
    public float secbetweencharacter = 0.15f;
    private int dialoguechange = 0;
    bool stop = true;

    // Use this for initialization
    void Start()
    {
        _textcom = GetComponent<Text>();
        _textcom.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && stop)
        {
            StartCoroutine(displaytext(dialoguestring[dialoguechange]));
        }
        if (_textcom.text == "doei")
        {
            panel.SetActive(false);
            _textcom.text = "";
        }
       // else if () { panel.SetActive(true); }
    }
    private IEnumerator displaytext(string texttodisplay)
    {
        Time.timeScale = 0;
        int textlenght = texttodisplay.Length;
        int currentcharacterindex = 0;
        _textcom.text = "";
        while (currentcharacterindex < textlenght)
        {
            Time.timeScale = 1;
            _textcom.text += texttodisplay[currentcharacterindex];
            currentcharacterindex++;
            if (currentcharacterindex < textlenght)
            {
                stop = false;
                yield return new WaitForSeconds(secbetweencharacter);
            }
            else
            {
                stop = true;
                break;
            }
        }
        // _textcom.text = "";
        dialoguechange += 1;
    }
}