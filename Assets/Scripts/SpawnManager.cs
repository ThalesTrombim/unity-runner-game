using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject obstaclePrefab;
  private Vector3 spawnPos = new Vector3(25, 0, 0);
  public float startDelay = 2f;
  public float repeatRate = 2f;

  void Start()
  {
    InvokeRepeating("SpawnObstacle", startDelay, repeatRate);       
  }

  void SpawnObstacle()
  {
    // Recebe o objeto e as coordenadas em que ele irá ser colocado.
    // 1 - objeto, 2 - posição, 3 - rotação
    Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
  }
}
