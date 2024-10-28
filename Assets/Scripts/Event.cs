using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public AudioClip desiredSound;  // Drag and drop your sound clip in the Unity Editor
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();

        // Ensure an AudioClip is assigned
        if (desiredSound == null)
        {
            Debug.Log("No sound assigned to the SoundManager!");
        }
    }

    // Call this method when your desired event occurs
    public void PlayDesiredSound()
    {
        // Check if AudioSource and AudioClip are assigned
        if (audioSource != null && desiredSound != null)
        {
            // Play the desired sound
            audioSource.PlayOneShot(desiredSound);
        }
        else
        {
            Debug.LogError("AudioSource or AudioClip not assigned!");
        }
    }
}