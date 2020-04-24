using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapController4 : MonoBehaviour
{
private int click = 0;
private bool cliker = false;
Sound sound;

private SpriteRenderer spriteR;
public Sprite coronaImg;
public Sprite corona2Img;
public Sprite corona3Img;

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
                //Debug.Log(click + "Click 1");
                spriteR.sprite = corona2Img;
                click++;
            }
            if(click == 2){
                sound.PlaySound();
                //Debug.Log(click + "Click 2");
                spriteR.sprite = coronaImg;
                click++;
            }
            if(click >= 4 && click <= 5){
                sound.PlaySound();
                //Debug.Log(click + "Click 3");
                  spriteR.sprite = corona3Img;
                  click++;  
            }
            if(click > 5){
                sound.PlaySound();
                //Debug.Log(click + "Click 4");
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
