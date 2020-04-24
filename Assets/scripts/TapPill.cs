using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapPill : MonoBehaviour
{

    public EnemyEnergy enemy;
    Sound sound;
    ScoreScript score;

    // Start is called before the first frame update
    void Start()
    {
        sound = FindObjectOfType<Sound>();
        score = FindObjectOfType<ScoreScript>();
    }

    void OnMouseDown(){
        if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            sound.PlaySound();
            enemy.TakeDamage(7);
            Destroy(gameObject);
            score.getScore(7);
        }
    }  

    // Update is called once per frame
    void Update()
    {
        
    }
}
