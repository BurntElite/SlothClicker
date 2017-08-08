using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {
    public float clicked;
    private float clickPS;
    private float clickA;

    private bool checkClick;

	void Start () {
        clickA = 1;
	}
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            checkClick = true;
        }
	}

    private void FixedUpdate()
    {
        if(checkClick == true)
        {
            ClickScore();
        }
    }

    private void ClickScore(){
        clicked = clicked + (clickA);
        checkClick = false;
	}
}
