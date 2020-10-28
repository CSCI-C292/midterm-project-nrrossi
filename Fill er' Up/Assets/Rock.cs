using System.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] float _rockFallSpeed = 0.01f;
    [SerializeField] float _timeUntilDestroy = 20;
    static int rockFilled = 0;
    bool onGround = true;
    bool levelComplete = false;
    bool levelFailed = false;
    float counter = 0f;

    // Update is called once per frame
    void Update()
    {

      //complete Level
      if (rockFilled >= 40)
      {
        rockFilled = 40;
        levelComplete = true;
        GameState.Instance.InitiateLevelComplete();
      }
      else if (GameState.Instance.getLives() == 0)
      {
        levelFailed = true;
        GameState.Instance.InitiateLevelFailed();
      }
    }

    //Tags reference: https://bladecast.pro/unity-tutorial/identify-object-tag-or-name-unity
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.CompareTag("DumpTruck"))
      {
        if (! levelFailed)
          rockFilled++;;
        
        onGround = false;
      }
      else if (other.CompareTag("Floor"))
      {
        if (!levelComplete)
          GameState.Instance.DecreaseLives();
        
        Destroy(gameObject, 5);
      }

    }

}
