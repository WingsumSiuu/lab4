using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerCutscene : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name == "right") {
            // to cutscene with natty
            SceneManager.LoadScene(2);
        }
    }
}
