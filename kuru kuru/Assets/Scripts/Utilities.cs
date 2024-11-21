using UnityEngine;
using UnityEngine.SceneManagement;

public class Utilities : MonoBehaviour
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
    public void TestFunctie()
    {
        Debug.Log("De knop werkt!");
    }
}
