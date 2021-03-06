﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    [SerializeField] private int _lives = 20;
    [SerializeField] GameObject _livesText;
    [SerializeField] GameObject _completeText;
    [SerializeField] GameObject _failedText;
    [SerializeField] GameObject _thanksForPlaying;
    [SerializeField] GameObject _helpMenu;

    public bool display = false;
    private bool moveTruck = true;

    //bool isLevelComplete = false;
    //bool isLevelFailed = false;

    public static GameState Instance;

    //getter for Lives
    public int getLives(){
        return _lives;
    }



    private void Awake() {
        Instance = this;
    }



  public void DecreaseLives()
  {
     if (_lives > 0)
     {
      _lives--;
      _livesText.GetComponent<Text>().text = "Lives: " + _lives;
     }
  }

public void InitiateLevelComplete()
{
    _completeText.SetActive(true);
    _thanksForPlaying.SetActive(true);
    if(moveTruck)
    {
        DumpTruck.Instance.MoveDumpTruck();
        moveTruck = false;
    }

}

public void InitiateLevelFailed()
{
    _failedText.SetActive(true);
}

public void ToggleHelpMenu()
{
        _helpMenu.SetActive(!display);
        display = !display;
}

}
