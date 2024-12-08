using UnityEngine;

public class MyUI : MonoBehaviour
{
   //laat je de quality aanpassen van het spel
    public void SetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }
    //je kan het spel op fullscreen en window mode zetten
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
