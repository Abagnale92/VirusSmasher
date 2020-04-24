using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapController2 : MonoBehaviour
{
private int click = 0;
private bool cliker = false;
private SpriteRenderer spriteR;
ScoreScript score;
public Sprite coronaImg;
public EnemyEnergy enemy;
Sound sound;
    void Start()
    {
        score = FindObjectOfType<ScoreScript>();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        sound = FindObjectOfType<Sound>();
    }

    void OnMouseDown(){
        if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
            cliker = true;
                if(cliker == true){
                    sound.PlaySound();
                    spriteR.sprite = coronaImg;
                    click++;
                if(click == 2){
                    sound.PlaySound();
                    enemy.TakeDamage(5);
                    Destroy(gameObject);
                    score.getScore(3);
                    }
                }
                else{
                    click++;
                    } 
        }
    }

}
