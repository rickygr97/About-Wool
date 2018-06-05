using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changesce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void sce(int nu)
    {
        SceneManager.LoadScene(nu);
    }

    public void qu()
    {
        Application.Quit();
    }

}
