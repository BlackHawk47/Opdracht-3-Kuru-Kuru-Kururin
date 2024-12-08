using UnityEngine;
using UnityEngine.SceneManagement;

public class Utilities : MonoBehaviour
{
    //laad de game scene in
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
    //laat zien dat de knop werkt
    public void TestFunctie()
    {
        Debug.Log("De knop werkt!");
    }
    //een knop voor een bonus level
    public void BonusLevel()
    {
        SceneManager.LoadScene("Bonus Level");
    }
}
