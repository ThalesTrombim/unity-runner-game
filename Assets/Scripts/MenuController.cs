using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
  public InputField playerName;

  void Start()
  {
        
  }

  public void StartGame()
  {
    if(playerName.text.Length > 0)
    {
      GameController.playerName = playerName.text;
      SceneManager.LoadScene("Main");
    } 
  }

  public void ExitGame()
  {
    Application.Quit();
  }
}
