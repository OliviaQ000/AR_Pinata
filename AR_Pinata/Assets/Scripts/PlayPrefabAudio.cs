using UnityEngine;

public class PlayPrefabAudio : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
       audioSource = GetComponent<AudioSource>();
    }

    public void ToggleMusic()
    {
        if(!audioSource.isPlaying)
            audioSource.Play();
        else
            audioSource.Pause();
    }
}
