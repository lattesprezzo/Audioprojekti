using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    PauseControl pauseControl;  

    public List<string> trackNames = new();
    public GameObject[] audioSources;


    private void Start()
    {

       // trackNames.Add(audioSource.name);  Jos halutaan GamePlayn aikana lisätä jotain listaan 
    }
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
