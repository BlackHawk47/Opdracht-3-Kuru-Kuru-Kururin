using UnityEngine;
using UnityEngine.SceneManagement;

public class Won : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
