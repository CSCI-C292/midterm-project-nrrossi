using System.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] float _rockFallSpeed = 0.01f;
    [SerializeField] float _timeUntilDestroy = 20;
    [SerializeField] GameState _gameState;
    [SerializeField] GameObject _dumpTruck;
    static int rockFilled = 0;
    bool onGround = true;
    float counter = 0f;

    // Update is called once per frame
    void Update()
    {

      //complete Level
      if (rockFilled == 40)
      {
        rockFilled = 41;

      }
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
      Debug.Log(other.gameObject);
      if(other.gameObject == _dumpTruck)
      {
        rockFilled++;
        Debug.Log(rockFilled);
        onGround = false;
      }
      else
      {
        GameState.Instance.DecreaseLives();
        Destroy(gameObject, 5);
      }

    }

}
