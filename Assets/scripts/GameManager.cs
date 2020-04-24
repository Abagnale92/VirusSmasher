using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]GameObject countdownPage;
    [SerializeField]GameObject gameOverPage;

    [SerializeField]GameObject enemySpawner;
    public EnemySpawner spawner;

    public EnemyEnergy health;

     ScoreScript score;
     [SerializeField] TextMeshProUGUI highScore;
     [SerializeField] TextMeshProUGUI endText;
     [SerializeField] TextMeshProUGUI buttonText;
     private int finalScore = 0;
     private int savedScore;

     private bool finalWin = false;

     private int currentSceneIndex;
     private int count = 0;


    enum PageState{
        None,
        Countdown,
        GameOver
    }
    
    public void OnPlayerDied(){
        SetPageState(PageState.GameOver);
        endText.text = "Hai Perso!";
        buttonText.text = "Restart";
        finalScore = score.returnScore();
        if(finalScore>savedScore){
        PlayerPrefs.SetInt("SavedScore", finalScore);
        }
        highScore.text = "High Score: " +PlayerPrefs.GetInt("SavedScore").ToString();
        
    }

    public void OnPlayerWin(){
        SetPageState(PageState.GameOver);
        if(!finalWin){
            endText.text = "Hai Vinto!";
            buttonText.text = "Next Level";
        }
        finalScore = score.returnScore();
        if(finalScore>savedScore){
        PlayerPrefs.SetInt("SavedScore", finalScore);
        }
        highScore.text = "High Score: " +PlayerPrefs.GetInt("SavedScore").ToString();
        
    }

    
    void OnEnable(){
        CountdownText.OnCountdownFinished += OnCountdownFinished;
    }

    void OnDisable(){
        CountdownText.OnCountdownFinished -= OnCountdownFinished;
    }

     void OnCountdownFinished(){
        SetPageState(PageState.None);
       
    }

    void SetPageState(PageState state){
        switch(state){
            case PageState.None:
                countdownPage.SetActive(false);
                gameOverPage.SetActive(false);
                enemySpawner.SetActive(true);
                spawner.SetSpawn(true);

                break;
            case PageState.Countdown:
                countdownPage.SetActive(true);
                gameOverPage.SetActive(false);
                enemySpawner.SetActive(false);
                break;
            case PageState.GameOver:
                countdownPage.SetActive(false);
                gameOverPage.SetActive(true);
                enemySpawner.SetActive(false);
                spawner.SetSpawn(false);
                break;    
        }
    }

    public void Start(){
        score = FindObjectOfType<ScoreScript>();
        SetPageState(PageState.Countdown);
        savedScore = PlayerPrefs.GetInt("SavedScore");
        
         if (SceneManager.GetActiveScene().name == "Game 2") {
                finalWin = true;
            }
    }

    public void Update(){
        if(health.GetHealth()>=100){
            OnPlayerDied();
        }
        else if (health.GetHealth()<=0){
            if(finalWin){
                endText.text = "Missione Compiuta!";
                buttonText.text = "Restart";
                }
            OnPlayerWin();
        }

    }

    public void Exit() {
		UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        FindObjectOfType<GameSession>().ResetGameSession();
		
    }

    public void Restart(){
        if(endText.text == "Hai Vinto!"){
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
            count++;
        }

        else if(endText.text == "Hai Perso!" || endText.text =="Missione Compiuta!"){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
            FindObjectOfType<GameSession>().ResetGameSession();
        }
    }

}
