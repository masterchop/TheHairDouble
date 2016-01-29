﻿using UnityEngine;
using System.Collections;

public class StartSceneButton : MonoBehaviour {
	public bool isMale = false;
	public bool isFemale = false;
    static public bool activeM;
    static public bool activeF;
    Color maincolor;
	Color onMouseEntercolor;
	Color onMouseClickColor;
    public float collisionRequired = 2.5f;
    private float collisionCurrent = 0.0f;


    // Use this for initialization
    void Start () {
		maincolor = new Color (0f, 0f, 0f, 1f);
		onMouseEntercolor = new Color (0.9607f, 0.6784f, 0.3450f, 1f);
		onMouseClickColor = new Color (0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)){
			switch (CameraPosition.posCamera) {
			case(1):
				Application.Quit();
				break;
			}

		
		}
	
	}

    void OnMouseEnter()
    {
        //Color of the Buttons on Mouse Enter
        GetComponent<Renderer>().material.color = onMouseEntercolor;
    }

    void OnMouseExit()
    {
        //Color of the buttons on Mouse Exit return to main color
        GetComponent<Renderer>().material.color = maincolor;
    }
    void OnMouseUp()
    {
        //Color of the buttons on Mouse Up
        GetComponent<Renderer>().material.color = onMouseClickColor;

        //Change the position of the Camera and select the correct body model for the gender selected
        if (isFemale)
        {
            CameraPosition.posCamera = 2;
            activeF = true;
            GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(999.88f, -675.04f, -3.43f);          
        }

        if (isMale)
        {
            CameraPosition.posCamera = 2;
            activeM = true;
            GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(999.28f, -674.69f, -3.5f);
        }


    }
    void OnCollisionEnter2D(Collision2D coll)
    {
       // Color of the Buttons on Collision Enter
        GetComponent<Renderer>().material.color = onMouseEntercolor;
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        collisionCurrent += Time.deltaTime;

        if (collisionCurrent > collisionRequired)
        {
            //Color of the buttons on Collision Stay
            GetComponent<Renderer>().material.color = onMouseClickColor;
            if (isFemale)
            {
                CameraPosition.posCamera = 2;
                activeF = true;
                GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(999.88f, -675.04f, -3.43f);
            }

            if (isMale)
            {
                CameraPosition.posCamera = 2;
                activeM = true;
                GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(999.28f, -674.69f, -3.5f);
            }

        }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        collisionCurrent = 0.0f;
        //Color of the buttons on Collision Exit return to main color
        GetComponent<Renderer>().material.color = maincolor;
    }
}
