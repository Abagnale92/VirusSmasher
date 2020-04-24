using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
      // Use this for initialization
    public Transform[] spawnPoints;
    public GameObject[] monsters;
    int randomSpawnPoint, randomMonster;
    public static bool spawnAllowed;
   

	void Start () {
        spawnAllowed = true;
        InvokeRepeating("SpawnAMonster", 0f, 1f);
	}
	
	// Update is called once per frame
	void SpawnAMonster () {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomMonster = Random.Range(0, monsters.Length);
            Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
		
	}

        public bool SetSpawn(bool spawn){
               return spawnAllowed = spawn;
        }

}
