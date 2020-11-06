using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField] GameObject _rockPrefab; //prefab of rock object for spawning
    [SerializeField] float _delay = 0.5f;   //delay of rock spawning

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

        //Rock Spawning
        if (Input.GetMouseButtonDown(0)){
          InvokeRepeating("DropRock", 0, _delay);
        }

        if (Input.GetMouseButtonUp(0)){
            CancelInvoke("DropRock");
        }


        //Help Menu
        if (Input.GetButtonDown("HelpMenu")){
            GameState.Instance.ToggleHelpMenu(); //toggles help menu
        }

        //Player Reset Level
        if (Input.GetButtonDown("Reset")){
            SceneManager.LoadScene("Tutorial"); //really ugly way to do it but it works
        }



    }

    private void DropRock(){
        Vector3 rockPos = new Vector3(transform.position.x, 4.25f, 1f); //position rock behind the player and towards the bottom of the dispenser 
                                                                        //(stops rocks from flying out the side if the player "whips" themselves quickly to one side)
        Instantiate(_rockPrefab, rockPos, Quaternion.identity); // Initiate Rock Drop       
    }


}
