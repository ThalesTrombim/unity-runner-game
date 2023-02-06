using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  public static float speed = 10f;
  public static float timeToSpawn = 3f;
  public static float score = 0;
  public static bool gameOver = false;

  void Start()
  {
    StartGame();
  }

  private void StartGame()
  {
    GameController.speed = 10f;
    GameController.timeToSpawn = 3f;
    GameController.score = 0;
    GameController.gameOver = false;

  }
}
