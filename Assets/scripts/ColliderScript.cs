using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
   public EnemyEnergy enemy;

   ScoreScript score;

   [SerializeField] AudioSource _as;

    void Start()
    {
        score = FindObjectOfType<ScoreScript>();
    }
   
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.name == "littleCorona(Clone)")
        {
            _as.Play();
            Destroy(collision.gameObject);
            if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            enemy.TakeEnergy(5);
            if(score.returnScore() >=1){
                score.setNegativeScore(1);
                }
            }
        }
        if ( collision.gameObject.name == "littleCorona2(Clone)")
        {
             _as.Play();
            Destroy(collision.gameObject);
            if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            enemy.TakeEnergy(5);
            if(score.returnScore() >=3){
                score.setNegativeScore(3);
                }
            else{
                score.setNegativeScore(score.returnScore());
                }
            }
        }
        if ( collision.gameObject.name == "littleCorona3(Clone)")
        {
             _as.Play();
            Destroy(collision.gameObject);
            if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            enemy.TakeEnergy(5);
            if(score.returnScore() >=5){
                score.setNegativeScore(5);
                }
            else{
                score.setNegativeScore(score.returnScore());
                }
            }
        }

         if ( collision.gameObject.name == "littleCorona4(Clone)")
        {
             _as.Play();
            Destroy(collision.gameObject);
            if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            enemy.TakeEnergy(5);
            if(score.returnScore() >=5){
                score.setNegativeScore(5);
                }
            else{
                score.setNegativeScore(score.returnScore());
                }
            }
        }

         if ( collision.gameObject.name == "pill(Clone)")
        {
             _as.Play();
            Destroy(collision.gameObject);
            
           /* if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            enemy.TakeDamage(7);
                score.getScore(7);
             } */
        }

        if ( collision.gameObject.name == "pill2(Clone)")
        {
             _as.Play();
            Destroy(collision.gameObject);
            /*if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            enemy.TakeDamage(9);
                score.getScore(9);
                } */
        }
    }
        
}
