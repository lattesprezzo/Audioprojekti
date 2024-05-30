using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreatherSound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip soundClip; // Assign this in the Inspector

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
