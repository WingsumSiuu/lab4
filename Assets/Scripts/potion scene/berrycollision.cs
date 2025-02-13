using UnityEngine;

public class berrycollision : MonoBehaviour
{
    public GameObject panel;

    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name == "bowl (tmp)") {
            panel.SetActive(true);
        }
    }
}
