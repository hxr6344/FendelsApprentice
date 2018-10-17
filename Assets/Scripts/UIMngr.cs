﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


///<summary> Handles all the toggling of menus </summary>
public class UIMngr : MonoBehaviour
{

    #region Singleton Instance Checks
    //Ensure there is only one instance of the UI manager
    private static UIMngr instance = null;
    public static UIMngr Instance
    {
        get
        {
            //Find the UI manager if it exists
            if(instance == null)
            {
                instance = FindObjectOfType<UIMngr>();
            }
            //Create a new one if it doesn't
            if(instance == null)
            {
                GameObject obj = new GameObject("UIMngr");
                instance = obj.AddComponent<UIMngr>();
            }

            return instance;
        }
    }

    //Ensure the instance is removed when the game is closed
    void OnApplicationQuit()
    {
        instance = null;
    }
    #endregion

    public GameObject hud;
    public GameObject options;
    public GameObject overlay;
    public GameObject mainMenu;
    public GameObject spellBook;
    private bool audioOn;

	// Use this for initialization
	void Start ()
    {
        mainMenu.SetActive(true);
        hud.SetActive(false);
        options.SetActive(false);
        //spellBook.SetActive(false);
        audioOn = true;
    }

    #region Main Menu
    public void StartGame()
    {
        //Toggle the HUD
        hud.SetActive(true);
        options.SetActive(false);
        mainMenu.SetActive(false);
        //spellBook.SetActive(false);
    }

    public void ToggleInstructions(GameObject instructions)
    {
        if (!instructions.active)
        {
            instructions.SetActive(true);
            mainMenu.SetActive(false);
        }
        else
        {
            instructions.SetActive(false);
            mainMenu.SetActive(true);
        }
    }

    public void ToggleCredits(GameObject credits)
    {
        if (!credits.active)
        {
            credits.SetActive(true);
            mainMenu.SetActive(false);
        }
        else
        {
            credits.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
    #endregion

    #region Options Menu
    //Toggles the options menu
    public void ToggleOptions()
    {
        if (hud.active)
        {
            Debug.Log("options enabled");
            hud.SetActive(false);
            options.SetActive(true);
            overlay.SetActive(true);
        }
        else
        {
            Debug.Log("options disabled");
            hud.SetActive(true);
            options.SetActive(false);
            overlay.SetActive(false);
        }
    }

    public void ToggleAudio(Text buttonText)
    {
        if (audioOn)
        {
            buttonText.text = "Off";
            audioOn = false;
        }
        else
        {
            audioOn = true;
            buttonText.text = "On";
        }
    }

    public void ToggleInstructOptions(GameObject instructions)
    {
        if (!instructions.active)
        {
            instructions.SetActive(true);
            options.SetActive(false);
        }
        else
        {
            instructions.SetActive(false);
            options.SetActive(true);
        }
    }
    #endregion

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
