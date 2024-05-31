using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    PauseControl pauseControl;  

    void PauseListener()
    {
        if(pauseControl.gameIsPaused)
        {
            audioSource.Pause();    
        }
        else
        {
            audioSource.UnPause(); 
        }
    }

    void Update()
    {
        PauseListener();    
    }
}
