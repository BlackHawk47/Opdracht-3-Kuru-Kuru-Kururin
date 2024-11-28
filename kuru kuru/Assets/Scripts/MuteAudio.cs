using UnityEngine;

public class MuteAudio : MonoBehaviour
{
public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 1f;
        }
    }
}
