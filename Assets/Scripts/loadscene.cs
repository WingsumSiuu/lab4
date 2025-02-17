using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public void PlayGame()
    {
        // build and run to see scene numbers
        SceneManager.LoadScene(1);
    }

    public void PlayRhythmGame()
    {
        // build and run to see scene numbers
        SceneManager.LoadScene(5);
    }

    public void resetPotion()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void MusicalElementScene() {
        SceneManager.LoadScene(6);
    }
}
