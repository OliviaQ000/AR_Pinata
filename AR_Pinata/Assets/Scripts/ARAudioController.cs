using UnityEngine;

public class ARAudioController : MonoBehaviour
{
    public void ToggleARAudio()
    {
        Debug.Log("Button Clicked");
        PlayPrefabAudio audio = FindObjectOfType<PlayPrefabAudio>();

        if(audio !=null)
        {
            audio.ToggleMusic();
        }
    }
}
