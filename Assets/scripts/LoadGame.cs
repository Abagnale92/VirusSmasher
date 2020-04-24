using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

    public void OnClickGame()
    {

        SceneManager.LoadScene(1);
    }

    public void OnClickMenu()
    {

        SceneManager.LoadScene("Menu");
    }

    public void OnClickInfo()
    {

        SceneManager.LoadScene("Info");
    }

    public void OnClickInstruction()
    {

        SceneManager.LoadScene("Istruzioni");
    }

    public void OnClickStore(){
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.GADeveloper.TappyDeLuke");
    }
}
