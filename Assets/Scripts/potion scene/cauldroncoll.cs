using UnityEngine;
using UnityEngine.UI;

public class cauldroncoll : MonoBehaviour
{
    [SerializeField] floatingslider progressBar;
    public AudioSource source;
    public AudioClip pss;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionStay2D(Collision2D col) {
        if (col.gameObject.CompareTag("berry")) {
            // don't delete berry if player is still dragging it
            draganddrop checkDrag = col.collider.GetComponent<draganddrop>();
            if (col.gameObject.name == "elderberry" && checkDrag != null && checkDrag.dragging == false) {
                source.PlayOneShot(pss);
                progressBar.addProgress(5);
                Destroy(col.collider.gameObject);
            }
            if (col.gameObject.name == "redberry" && checkDrag != null && checkDrag.dragging == false) {
                source.PlayOneShot(pss);
                progressBar.addProgress(3);
                Destroy(col.collider.gameObject);
            }  
            if (col.gameObject.name == "greenberry" && checkDrag != null && checkDrag.dragging == false) {
                source.PlayOneShot(pss);
                progressBar.addProgress(-1);
                Destroy(col.collider.gameObject);
            } 
            if (col.gameObject.name == "blueberry" && checkDrag != null && checkDrag.dragging == false) {
                source.PlayOneShot(pss);
                progressBar.addProgress(1);
                Destroy(col.collider.gameObject);
            }
        }
    }
}
