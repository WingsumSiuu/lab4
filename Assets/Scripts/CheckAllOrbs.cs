using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class CheckAllOrbs : MonoBehaviour
{
    public TextMeshProUGUI errorText;

    public void checkLeave() {
        GameObject pinkorb = GameObject.Find("Pink Orb");
        GameObject orangeorb = GameObject.Find("Orange Orb");
        GameObject yelloworb = GameObject.Find("Yellow Orb");
        GameObject greenorb = GameObject.Find("Green Orb");
        GameObject blueorb = GameObject.Find("Blue Orb");
        GameObject purpleorb = GameObject.Find("Purple Orb");
        if (pinkorb && orangeorb && yelloworb && greenorb && blueorb && purpleorb) {
            SceneManager.LoadScene(11);
        } else {
            errorText.text = "(You may not leave until all the orbs are in place.)";
        }
    }
}
