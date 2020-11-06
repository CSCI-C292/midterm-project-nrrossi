using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumpTruck : MonoBehaviour
{


    public static bool moveTruck = false;
    private void Update() {

        if(moveTruck)
        //transform.position += new Vector3(0, Time.deltaTime * 2f, 0);
        transform.position += new Vector3(Time.deltaTime * .5f, 0, 0);
    }



 public static DumpTruck Instance;

    private void Awake() {
        Instance = this;
    }

    public void MoveDumpTruck(){

    
    //InvokeRepeating("Rumble", 0, 1f); //Rumble does not work...
    
    //moveTruck = true;

    }

    void MoveOff(){
    transform.position += new Vector3(Time.deltaTime * .1f, 0, 0);

    }

    void Rumble(){

        float counter = 0f;

     transform.position += new Vector3(0, 5f, 0);
     while(counter < .5)
         counter += Time.deltaTime;
     
     transform.position -= new Vector3(0, 5f, 0);
    }

    
}
