using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField] int _lives = 20;
    public static GameState Instance;

    private void Awake() {
        Instance = this;
    }



  public void DecreaseLives()
  {
      _lives--;
  }


}
