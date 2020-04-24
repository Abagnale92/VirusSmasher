using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreT;
    int score = 0;
    // Start is called before the first frame update
    
    void Start(){
        //scoreT = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //scoreT.text = "Score " + score.ToString();
    }

    public void getScore(int num){   
          score += num;
    }

    public void setNegativeScore(int num){   
          score -= num;
    }

    public int returnScore(){
        return score;
    }
}
