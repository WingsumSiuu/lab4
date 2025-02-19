using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerCutscene : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name == "right") {
            string activeScene = SceneManager.GetActiveScene().name; 
            if (activeScene == "SampleScene") {
                GameObject orb1 = GameObject.Find("blueorb_0");
                GameObject orb2 = GameObject.Find("yelloworb_0");
                GameObject orb3 = GameObject.Find("greenorb_0 (1)");
                GameObject orb4 = GameObject.Find("orangeorb_0 (1)");
                if (orb1 == null && orb2 == null && orb3 == null && orb4 == null) {
                    // to cutscene with natty
                    SceneManager.LoadScene(2);
                }
            } else if (activeScene == "walkToPutOrbs") {
                SceneManager.LoadScene(10);
            }
        }
    }
}
