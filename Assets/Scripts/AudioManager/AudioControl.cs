using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (SceneManager.GetActiveScene().name == "SecondLevel")
        {
            audioSources[0].GetComponent<AudioSource>().Play();
        }

        // trackNames.Add(audioSource.name);  Jos halutaan GamePlayn aikana lisätä jotain listaan 
    }
    void PauseListener()
    {
        if (pauseControl.gameIsPaused)
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
