using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGui : MonoBehaviour {

    public Text scoreDisplay;
    Click clickScript;
    private float score;
	// Use this for initialization
	void Start () {
        clickScript = GameObject.Find("LevelManager").GetComponent<Click>();
	}
	
	// Update is called once per frame
	void Update () {
        score = clickScript.clicked;
        ScoreAdd();
	}

    private void ScoreAdd()
    {
        scoreDisplay.text = "Clicks: " + score;
    }
}
