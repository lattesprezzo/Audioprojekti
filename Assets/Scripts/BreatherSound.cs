
using UnityEngine;

public class BreatherSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    public AudioClip soundClip; // Assign this in the Inspector

    private void Start()
    {
     //   audioSource = GetComponent<AudioSource>(); // Ei tarvita, jos ollaan manuaalisesti laitettu slottiin
    }

    // Call this function to play the assigned sound clip
    public void PlaySound()
    {
        if (soundClip != null)
        {
            audioSource.PlayOneShot(soundClip);
        }
        else
        {
            Debug.LogWarning("No sound clip assigned!");
        }
    }
}
