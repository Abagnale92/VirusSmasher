using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Sound : MonoBehaviour
{
    public AudioSource mySound;
    // Start is called before the first frame update
    void Start()
    {
        mySound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(){
        mySound.Play();
    }
}
