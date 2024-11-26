using UnityEngine;

public class MyUI : MonoBehaviour
{
    public GameObject myUIObject;

    public void ShowMyUI()
    {
        myUIObject.SetActive(true);
    }

    public void HideMyUI()
    {
        myUIObject?.SetActive(false);
    }

    public void SetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
