using System.Collections;
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
   private begingame begin;


    // Use this for initialization
    void Start()
    {
        _textcom = GetComponent<Text>();
        _textcom.text = "";
        begin = FindObjectOfType<begingame>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && stop && dialoguechange < dialoguestring.Length)
        {
            StartCoroutine(displaytext(dialoguestring[dialoguechange]));
        }
        if (Input.GetKeyDown(KeyCode.E) && _textcom.text == "je eerste doel is om door elke ringen heen te vliegen tewijl je de targets schiet doe je best")
        {
            panel.SetActive(false);
            _textcom.text = "";
            begin.ContinueGame();
        }
       // else if () { panel.SetActive(true); }
    }
    private IEnumerator displaytext(string texttodisplay)
    {
        int textlenght = texttodisplay.Length;
        int currentcharacterindex = 0;
        _textcom.text = "";
        while (currentcharacterindex < textlenght)
        {
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
