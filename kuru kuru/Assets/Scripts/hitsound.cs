using UnityEngine;

public class hitsound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
