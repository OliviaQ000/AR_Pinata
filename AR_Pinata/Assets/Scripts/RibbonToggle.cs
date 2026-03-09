using UnityEngine;

public class RibbonToggle : MonoBehaviour
{
    public GameObject ribbon;
    bool isVisible = false; //let ribbon invisible at start

    public void ToggleRibbon()
    {
        isVisible = !isVisible;  //each time press the button, reverse the visibility of ribbon
        ribbon.SetActive(isVisible);
    }
}
