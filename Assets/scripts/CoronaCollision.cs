using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaCollision : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.name == "pill(Clone)" || collision.gameObject.name == "pill2(Clone)")
        {
            //ScoreScript.scoreValue -= 1;
            Destroy(collision.gameObject);
        }
        
    }
}
