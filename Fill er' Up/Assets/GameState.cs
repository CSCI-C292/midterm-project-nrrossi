using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    [SerializeField] int _lives = 20;
    [SerializeField] GameObject _livesText;
    public static GameState Instance;

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


}
