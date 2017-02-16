﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform goal;
    public DataCollector dataCollector;
    public Navigator navigator;

    public enum Mode {scriptSet, menu, game, survey };
    public Mode mode;
    private Mode initMode = Mode.game;

    private bool pauseState = false;

    public bool isPaused()
    {
        return pauseState;
    }
    
    public void pause()
    {
        pauseState = true;
        Time.timeScale = 0;
    }

    public void resume()
    {
        pauseState = false;
        Time.timeScale = 1;
    }

    // Use this for initialization
    void Start ()
    {
        dataCollector = FindObjectOfType<DataCollector>();
        navigator = FindObjectOfType<Navigator>();
        //print("Game Script: started");
        //StartCoroutine("playerThinksTheyAreThere");
        if(mode == Mode.scriptSet) mode = initMode;
    }

    void playerThinksTheyAreThere()
    {
        //LOW: implement and test
        //Collect Data
        //Move Player
        //Set New Destination
        navigator.recalcPath(); //LOW: check for issues here
            
    }

	// Update is called once per frame
	void Update ()
    {
        //print("GameController.mode: " + mode.ToString());
        
        switch(mode)
        {
            case GameController.Mode.game:
                {
                    if(isPaused())
                    {
                        // Paused
                        if(Input.GetButtonUp("Pause"))
                        {

                            resume();

                        }
                    }
                    else
                    {
                        // Play
                        if(Input.GetButtonUp("Arrival"))
                        {
                            playerThinksTheyAreThere();
                        }
                        if(Input.GetButtonUp("Pause"))
                        {
                            
                            pause();
                            
                        }
                    }
                    break;
                }
            case GameController.Mode.menu:
                {
                    // Main menu
                    break;
                }
            case GameController.Mode.survey:
                {
                    // Survey
                    break;
                }
            default:
                {
                    print("GameController.Update - unhandled GameController.Mode");
                    break;
                }
        }
	}
}
