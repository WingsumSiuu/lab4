using UnityEngine;
using UnityEngine.SceneManagement;

public class hideInventory : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject inventory = GameObject.Find("Inventory");
        if (inventory != null) {
            inventory.SetActive(false);
        }
    }
}
