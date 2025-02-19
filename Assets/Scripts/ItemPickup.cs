using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;

    void Pickup() {
        if (gameObject.tag == "Orb") {
            InventoryManager.Instance.Add(Item);
            transform.parent = null;
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        Pickup();
        Debug.Log("clicked");
    }
}
