using UnityEngine;

public class PlayStoryAudio : MonoBehaviour
{
    public AudioSource audioSource;

    public void ToggleMusic()
    {
        if(!audioSource.isPlaying)
            audioSource.Play();
        else
            audioSource.Pause();
    }
}
