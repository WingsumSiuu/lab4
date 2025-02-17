using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void PlayGame()
    {
        // build and run to see scene numbers
        SceneManager.LoadScene(1);
    }

    public void PlayRhythmGame()
    {
        // build and run to see scene numbers
        SceneManager.LoadScene(3);
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void MusicalElementScene() {
        SceneManager.LoadScene(4);
    }
}
