using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Assigns player the position of the mouse to control left and right movement
        //while locking the Y axis
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, transform.position.y, 0);

        //Prevents player from moving off screen
        if(mousePos.x > 8.4){
            transform.position = new Vector3(8.4f, transform.position.y, 0);
        }
        
        //Prevents player from moving off screen
        if(mousePos.x < -8.4){
            transform.position = new Vector3(-8.4f, transform.position.y, 0);
        }
    }
}
