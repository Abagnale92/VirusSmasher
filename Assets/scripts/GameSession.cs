using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{

     [SerializeField]TextMeshProUGUI scoreText;
     ScoreScript score;
     private void Awake()
    {
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<ScoreScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text ="Score " + score.returnScore().ToString();
    }

      public void ResetGameSession()
    {
        //SceneManager.LoadScene(1);
        Destroy(gameObject);
    }

}
