using UnityEngine;

public class OptionsMenuController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool opening;

    public void HandleClick()
    {
        if (opening)
        {
            animator.Play("Close");
        } else
        {
            animator.Play("Open");
        }
        opening = !opening;
    }
   
}
