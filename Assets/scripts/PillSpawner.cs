using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillSpawner : MonoBehaviour
{
    
    public Transform[] spawnPoints;
    public GameObject[] pills;
    int randomSpawnPoint, randomMonster;
    public static bool spawnAllowed;

    EnemyEnergy health;
   

	void Start () {
        health = FindObjectOfType<EnemyEnergy>();
        spawnAllowed = true;
        InvokeRepeating("SpawnAMonster", 0f, 3f);
	}
	
	// Update is called once per frame
    void Update(){

    }

	void SpawnAMonster () {
        if (spawnAllowed && health.GetHealth() >= 70 )
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomMonster = Random.Range(0, pills.Length);
            Instantiate(pills[randomMonster], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
		
	}

        public bool SetSpawn(bool spawn){
               return spawnAllowed = spawn;
        }


}
