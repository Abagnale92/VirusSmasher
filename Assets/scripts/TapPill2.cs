using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapPill2 : MonoBehaviour
{
   
    public EnemyEnergy enemy;
    ScoreScript score;
    Sound sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = FindObjectOfType<Sound>();
        score = FindObjectOfType<ScoreScript>();
    }

    void OnMouseDown(){
        if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            enemy.TakeEnergy(9);
            sound.PlaySound();
            Destroy(gameObject);
            score.getScore(9);
            /*if(score.returnScore()>=9){
            score.setNegativeScore(9);
            }
            else{
                score.setNegativeScore(score.returnScore());
                } */
        } 
    }  

    // Update is called once per frame
    void Update()
    {
        
    }
}
