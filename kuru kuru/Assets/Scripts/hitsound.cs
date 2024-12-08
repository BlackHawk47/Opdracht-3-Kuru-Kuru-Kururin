using UnityEngine;

public class hitsound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    //maakt een geluid als je de muur raakt
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
