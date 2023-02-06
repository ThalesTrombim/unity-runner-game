using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject[] obstaclesPrefab;
  private Vector3 spawnPos = new Vector3(25, 0, 0);
  //public float startDelay = 2f;
  //public float repeatRate = 2f;
  private IEnumerator courountine;

  void Start()
  {
    //InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    courountine = SpawnObstacles();
    StartCoroutine(courountine);
  }

  private IEnumerator SpawnObstacles()
  {
    // Recebe o objeto e as coordenadas em que ele irá ser colocado.
    // 1 - objeto, 2 - posição, 3 - rotação
    //Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    while(true)
    {
      CreateObstacle();
      yield return new WaitForSeconds(3f);
    }
  }

  private void CreateObstacle()
  {
    GameObject obstacle = obstaclesPrefab[Random.Range(0, obstaclesPrefab.Length)];
    Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
  } 
}
