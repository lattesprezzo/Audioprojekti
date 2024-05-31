using UnityEngine;

public class PauseControl : MonoBehaviour
{
    [SerializeField]
    GameObject pausemenu;

    public bool gameIsPaused;

    public void TogglePauseMenu()
    {
        if (pausemenu != null)
        {
            if (pausemenu.activeSelf)
            {
                pausemenu.SetActive(false);
                Time.timeScale = 1f;
                gameIsPaused = false;
            }
            else
            {
                pausemenu.SetActive(true);
                Time.timeScale = 0f;
                gameIsPaused = true;

            }


        }

    }


    void Start()
    {
        pausemenu.SetActive(false);
    }


    void Update()
    {

    }
}
