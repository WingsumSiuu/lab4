using UnityEngine;
using UnityEngine.SceneManagement;

public class checkPurple : MonoBehaviour
{
    void Update()
    {
        GameObject orb = GameObject.Find("purpleorb");
        if (orb == null) {
            SceneManager.LoadScene(9);
        }

    }
}
