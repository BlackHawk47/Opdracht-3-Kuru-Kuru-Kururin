using UnityEngine;
using UnityEngine.SceneManagement;

public class Won : MonoBehaviour
{
    //opnieuw spelen
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }
    //sluit het spel af
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
