using UnityEngine;
using UnityEngine.UI;

public class cauldroncoll : MonoBehaviour
{
    //public CircleCollider2D cauldronCollider;
    [SerializeField] floatingslider progressBar;

    void Start()
    {
    }

    void OnCollisionStay2D(Collision2D col) {
        if (col.gameObject.CompareTag("berry")) {
            // don't delete berry if player is still dragging it
            draganddrop checkDrag = col.collider.GetComponent<draganddrop>();
            if (col.gameObject.name == "elderberry" && checkDrag != null && checkDrag.dragging == false) {
                progressBar.addProgress(5);
                Destroy(col.collider.gameObject);
            }
            if (col.gameObject.name == "redberry" && checkDrag != null && checkDrag.dragging == false) {
                progressBar.addProgress(2);
                Destroy(col.collider.gameObject);
            }  
            if (col.gameObject.name == "greenberry" && checkDrag != null && checkDrag.dragging == false) {
                progressBar.addProgress(-1);
                Destroy(col.collider.gameObject);
            } 
            if (col.gameObject.name == "blueberry" && checkDrag != null && checkDrag.dragging == false) {
                progressBar.addProgress(1);
                Destroy(col.collider.gameObject);
            }
        }
    }
}
