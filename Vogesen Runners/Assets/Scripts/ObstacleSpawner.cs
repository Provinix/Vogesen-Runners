using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;

    void Start()
    {
        StartCoroutine (SpawnRandomObstacle());
    }

    IEnumerator SpawnRandomObstacle()
    {
        // Warte eine gewisse Zeit
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        // Aktiviere Hindernisse
        int index = Random.Range(0, obstacles.Length);
        var obstacle = obstacles [index];

        if(obstacle.transform.tag == "Coin"){
            var position = transform.position;
            position.y += Random.Range(0f, 6f);
            Instantiate (obstacle, position, Quaternion.identity);
        }else
        {
            Instantiate (obstacle, transform.position, Quaternion.identity);
        }
        StartCoroutine(SpawnRandomObstacle());
    }
}