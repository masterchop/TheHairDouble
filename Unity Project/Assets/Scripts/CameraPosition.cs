﻿
using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {
	
	static public int posCamera;

	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
		PosizioneCamera ();
	
	}

	void PosizioneCamera(){
        //Move the Camera through the scenes
        //Change the GestureBody Movement
		switch (posCamera) {
			case(1):
				transform.position = new Vector3 (-1000f, 0f, -17f);
                //BodySourceView.body.transform.position = new Vector3(-1000f, 0f, 0f);
                break;
			case(2):
                transform.position = new Vector3(1000f, -670f, -17f);
                //BodySourceView.body.transform.position = new Vector3(1000f, -670f, 0f);
                break;	
            case(3):
                transform.position = new Vector3(-1000f, -500f, -17f);
                //BodySourceView.body.transform.position = new Vector3(-1000f, -500f, 0f);
                break;
            case (4):
                transform.position = new Vector3(0f, -500f, -17f);
                //BodySourceView.body.transform.position = new Vector3(0f, -500f, 0f);
                break;
			

		}
	}
}
