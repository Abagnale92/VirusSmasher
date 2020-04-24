using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapController3 : MonoBehaviour
{
    private int click = 0;
private bool cliker = false;

private SpriteRenderer spriteR;
public Sprite coronaImg;
public Sprite corona2Img;
Sound sound;

 ScoreScript score;
 public EnemyEnergy enemy;
    void Start()
    {
        sound = FindObjectOfType<Sound>();
        score = FindObjectOfType<ScoreScript>();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        
    }

    void OnMouseDown(){
        if(enemy.GetHealth()<100 && enemy.GetHealth()>0){
        cliker = true;
        if(cliker == true && click == 0){
            sound.PlaySound();
            spriteR.sprite = corona2Img;
            click++;
        }
        if(click == 2){
            sound.PlaySound();
            spriteR.sprite = coronaImg;
            click++;
        }
        if(click > 3){
            sound.PlaySound();
            enemy.TakeDamage(5);
            Destroy(gameObject);
            score.getScore(5);    
        }
           
        else{
        click++;
        } 
        }
    }
}
