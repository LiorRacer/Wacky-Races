﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class PauseGameMenuScript : MonoBehaviour
{

    public Canvas pauseMenu;

    public void Start()
    {
        pauseMenu = pauseMenu.GetComponent<Canvas>();
        pauseMenu.enabled = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.enabled = !pauseMenu.enabled;
            //GetComponentsInParent() //disable the music
            //menu.SetActive(isShowing);
        }
    }

    public void ReturnToMainMenu()
    {
        if(PlayerPrefs.GetString(Globals.GamePrefs.GameMode.ToString()).Equals(Globals.GameMode.MultiPlayer.ToString()))
        {
            PhotonNetwork.DestroyPlayerObjects(PhotonNetwork.player);
            Debug.Log("leaving the room");
        }
        Application.LoadLevel(0);
    }

    public void Cancel()
    {
        pauseMenu.enabled = false;
    }
}
