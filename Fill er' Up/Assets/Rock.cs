using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] float _rockFallSpeed = 0.01f;

    static int rockFilled = 0;

    bool onGround = true;
    [SerializeField] float _timeUntilDestroy = 20;
    float counter = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      //destroy rocks on floor

      if (counter < _timeUntilDestroy)
      {
        counter += Time.deltaTime;
      }
      else if (onGround)
      {
        Destroy(gameObject);
      }
      else {}


      //complete Level
      if (rockFilled == 40)
      {
        Debug.Log("Level Complete");
        rockFilled = 41;
      }
       // transform.position -= new Vector3(0, Time.deltaTime * _rockFallSpeed, 0); //Old Drop Mechanic

    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        rockFilled++;
        Debug.Log(rockFilled);
        onGround = false;

    }

}
