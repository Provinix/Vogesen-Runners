using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject[] obstacles;
    //public List<GameObject> obstaclesToSpawn = new List<GameObject>();

   
    /*void Awake() 
    {
        InitObstacles ();
    }*/

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (SpawnRandomObstacle());
    }

    /*void InitObstacles()
    {
        
        // Initialisiere die Hindernisse
        for (int i = 0; i < obstacles.Length; i++)
        {
            GameObject obj = Instantiate (obstacles [i], transform.position, Quaternion.identity);
            obj.SetActive(false);
            obstaclesToSpawn.Add (obj);
            
        }
    }*/

    IEnumerator SpawnRandomObstacle()
    {
        // Warte eine gewisse Zeit
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        // Aktiviere Hindernisse
        int index = Random.Range(0, obstacles.Length);
        GameObject obj = Instantiate (obstacles[index], transform.position, Quaternion.identity);
        StartCoroutine(SpawnRandomObstacle());
    }
}