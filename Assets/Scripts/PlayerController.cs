using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  private Rigidbody playerRb;
  public float jumpForce = 10f;
  public float gravityModifier = 1f;
  public bool isOnGround = true;

  void Start()
  {
    playerRb = GetComponent<Rigidbody>();
    Physics.gravity *= gravityModifier;
  }

  // Update is called once per frame
  void Update()
  {
    float space = Input.GetAxis("Jump");

    if(space!=0 && isOnGround && !GameController.gameOver)
    {
      playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
      isOnGround = false;
    }    
  }

  private void OnCollisionEnter(Collision collision)
  {
    isOnGround = true;
  }
}
