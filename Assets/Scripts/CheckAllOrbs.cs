using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckAllOrbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject pinkorb = GameObject.Find("Pink Orb");
        GameObject orangeorb = GameObject.Find("Orange Orb");
        GameObject yelloworb = GameObject.Find("Yellow Orb");
        GameObject greenorb = GameObject.Find("Green Orb");
        GameObject blueorb = GameObject.Find("Blue Orb");
        GameObject purpleorb = GameObject.Find("Purple Orb");
        if (pinkorb && orangeorb && yelloworb && greenorb && blueorb && purpleorb) {
            SceneManager.LoadScene(11);
        }

    }
}
