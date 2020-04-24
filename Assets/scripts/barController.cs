using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barController : MonoBehaviour
{

 public Slider slider;

    public void SetHealth(int health){
        slider.value = health;
        //Debug.Log("valore iniziale:"+ slider.value);
    }
    
}
