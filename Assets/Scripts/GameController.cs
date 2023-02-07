using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  public static float speed = 10f;
  public static float timeToSpawn = 3f;
  public static float score = 0;
  public static bool gameOver = false;

  public static string playerName;
  public static string playerNameHighScore;
  public static float highScore = 0f;

  void Start()
  {
    StartGame();
  }

  private void StartGame()
  {
    GameController.LoadData(); // <- load highscore
    GameController.speed = 10f;
    GameController.timeToSpawn = 3f;
    GameController.score = 0;
    GameController.gameOver = false;
    InvokeRepeating("ChangeDificult", 1f, 5f);
  }

  private void ChangeDificult()
  {
    if(!GameController.gameOver)
    {
      GameController.speed += 1;
      GameController.timeToSpawn = Mathf.Clamp(GameController.timeToSpawn - 0.5f, 1.5f, 5f);

      GameController.score += 5;
    }
  }


  public static void LoadData()
  {
    GameController.highScore = PlayerPrefs.GetFloat("HighScore", 0f);
    GameController.playerNameHighScore = PlayerPrefs.GetString("playerNameHighScore", "Player 1");
  }

  public static void SaveData()
  {
    if (GameController.score > GameController.highScore)
    {
      PlayerPrefs.SetFloat("HighScore", GameController.score);
      PlayerPrefs.SetString("playerNameHighScore", GameController.playerName);

      GameController.highScore = GameController.score;
      GameController.playerNameHighScore = GameController.playerName;

      PlayerPrefs.Save();
    }
  }
}
