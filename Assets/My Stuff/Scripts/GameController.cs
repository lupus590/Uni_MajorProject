﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        print("Game Script: started");
    }
	
    void playerThinksTheyAreThere()
    {

    }

	// Update is called once per frame
	void Update ()
    {
		if(Input.GetButton("Fire1"))
        {
            //print("FIRE!");
        }
	}
}
