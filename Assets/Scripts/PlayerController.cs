using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
  private Rigidbody playerRb;
  private Animator playerAnimator;
  private AudioSource playerAudio;

  public float jumpForce = 10f;
  public float gravityModifier = 1f;
  public bool isOnGround = true;

  public ParticleSystem explosionParticle;
  public ParticleSystem dirtParticle;

  public AudioClip jumpClip;
  public AudioClip crashClip;


  void Start()
  {
    playerRb = GetComponent<Rigidbody>();
    playerAnimator = GetComponent<Animator>();
    playerAudio = GetComponent<AudioSource>();

    Physics.gravity = new Vector3(0f, -16.7f, 0);
  }

  void Update()
  {
    float space = Input.GetAxis("Jump");

    if(space!=0 && isOnGround && !GameController.gameOver)
    {
      playerAudio.PlayOneShot(jumpClip);
      playerAnimator.SetTrigger("Jump_trig");
      playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
      isOnGround = false;
      dirtParticle.Stop();
    }    
  }

  private void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.CompareTag("ground"))
    {
      isOnGround = true;
      dirtParticle.Play();
    } else if(collision.gameObject.CompareTag("obstacles"))
    {
      GameController.gameOver = true;
      playerAnimator.SetBool("Death_b", true);
      playerAnimator.SetInteger("DeathType_int", 1);
      explosionParticle.Play();
      dirtParticle.Stop();
      playerAudio.PlayOneShot(crashClip, 0.5f);
      Invoke("GoToGameOver", 5f);
    }
  }

  private void GoToGameOver()
  {
    SceneManager.LoadScene("GameOver");
  }
}
