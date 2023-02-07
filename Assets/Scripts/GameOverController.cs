using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
  public Text score;
  public Text scoreBackground;

  public Text highScore;
  public Text highScoreBackground;

  void Start()
  {
    GameController.SaveData();
    score.text = "Player: " + GameController.playerName + " Score: " + GameController.score.ToString();
    scoreBackground.text = "Player: " + GameController.playerName + " Score: " + GameController.score.ToString();

    highScore.text = "Highscore: " + GameController.playerNameHighScore + " score: " + GameController.highScore.ToString();
    highScoreBackground.text = "Highscore: " + GameController.playerNameHighScore + " score: " + GameController.highScore.ToString();

    Invoke("GoToMenu", 5f);
  }

  // Update is called once per frame
  void Update()
  {
  }

  private void GoToMenu()
  {
    SceneManager.LoadScene("Menu");
  }

}
