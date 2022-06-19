using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Enemy Prefab:
    public GameObject enemyToSpawnPrefab;
    // Spawn Timer:
    public int spawnTimer;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemies());
    }


    IEnumerator spawnEnemies(){
        while (true){
            Instantiate(enemyToSpawnPrefab, this.transform.position, this.transform.rotation);
            yield return new WaitForSeconds(spawnTimer);
        }
    }


}
