using UnityEngine;
using UnityEngine.SceneManagement;

public class tpifwall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name == "right") {
            SceneManager.LoadScene(2);
        }
    }
}
