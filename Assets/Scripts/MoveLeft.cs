using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
  //private float speed = 10f;
  private float leftBound = -20f;

  void Start()
  {
        
  }

  // Update is called once per frame
  void Update()
  {
    if(!GameController.gameOver)
    {
      transform.Translate(Vector3.left * GameController.speed * Time.deltaTime);      
    }
    if(transform.position.x < leftBound && gameObject.CompareTag("obstacles"))
    {
      Destroy(gameObject);
    }
  }
}
