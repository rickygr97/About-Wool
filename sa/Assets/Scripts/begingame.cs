﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class begingame : MonoBehaviour {

    public GameObject plane;

    public GUIText text;


    public GameObject firstpscript;


    [SerializeField]

    void Start()
    {

        PauseGame();
        

    }
    void Update()
    {

    }





    private void PauseGame()
    {
      //  Time.timeScale = 0;

        //Disable scripts that still work while timescale is set to 0  


        plane.GetComponent<AirPlane>().enabled = (false);

        
        Cursor.visible = true;
    }
    public void ContinueGame()
    {
        //   Time.timeScale = 1;

        //enable the scripts again

        plane.GetComponent<AirPlane>().enabled = (true);


        Cursor.visible = false;
    }
}
