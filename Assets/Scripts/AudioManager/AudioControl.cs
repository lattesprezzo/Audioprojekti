using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioControl : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    PauseControl pauseControl;

    public List<string> levelNames = new();
    public GameObject[] audioSources;

    void SceneChecker()
    {

        if (SceneManager.GetActiveScene().name == levelNames[0])
        {
            Debug.Log("Should play Crickets song");
            audioSources[0].GetComponent<AudioSource>().Play();
        }
        else
        {
            Debug.Log("Wrong Scene!");
        }
    }

    private void Start()
    {


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
        SceneChecker(); 
    }
}
