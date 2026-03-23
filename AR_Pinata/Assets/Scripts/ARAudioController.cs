using UnityEngine;

public class ARAudioController : MonoBehaviour
{
    public void ToggleARAudio()
    {
        Debug.Log("Button Clicked");
        PlayPrefabAudio audio = FindObjectOfType<PlayPrefabAudio>(); //find the script on the prefab

        if(audio !=null)
        {
            audio.ToggleMusic();
        }
    }
}
