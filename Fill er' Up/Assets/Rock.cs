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

    //Tags reference: https://bladecast.pro/unity-tutorial/identify-object-tag-or-name-unity
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.CompareTag("DumpTruck"))
      {
        rockFilled++;
        Debug.Log(rockFilled);
        onGround = false;
      }
      else if (other.CompareTag("Floor"))
      {
        GameState.Instance.DecreaseLives();
        Destroy(gameObject, 5);
      }

    }

}
