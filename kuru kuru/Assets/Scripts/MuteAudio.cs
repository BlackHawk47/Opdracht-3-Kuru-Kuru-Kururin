using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    //zorgt er voor dat je het geluid uit kan zetten
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
