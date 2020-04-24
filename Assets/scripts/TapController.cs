using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TapController : MonoBehaviour
{



    public EnemyEnergy enemy;
    
    Sound sound;
   ScoreScript score;
    


    void Start(){
        score = FindObjectOfType<ScoreScript>();
        sound = FindObjectOfType<Sound>();
    }


    void OnMouseDown(){
        if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            enemy.TakeDamage(5);
            sound.PlaySound();
            Destroy(gameObject);
            score.getScore(1);
        }
    }  

    void Update(){
    
    }

   

}
