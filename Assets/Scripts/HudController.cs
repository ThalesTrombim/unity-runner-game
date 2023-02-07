using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
  public Text score;

  void Start()
  {
        
  }

  // Update is called once per frame
  void Update()
  {
    if(score != null)
    {
      score.text = "SCORE: " + GameController.score.ToString();
    }
  }
}
