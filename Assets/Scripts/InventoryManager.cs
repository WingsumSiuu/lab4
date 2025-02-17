using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    public Transform ItemContent;
    public GameObject InventoryButtonPrefab;
    public GameObject ItemPrefab;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
            return;
        }
    }

    public void Add(Item item)
    {
        Items.Add(item);
        ListItems();
    }

    // Update is called once per frame
    public void Remove(Item item)
    {
        Items.Remove(item);
        ListItems();
    }

    public void ListItems() {
        foreach (Transform Item in ItemContent) {
            Destroy(Item.gameObject);
        }

        foreach (var item in Items) {
            GameObject obj = Instantiate(InventoryButtonPrefab, ItemContent);
            var itemButton = obj.GetComponent<Button>(); 
            var itemImage = obj.GetComponent<Image>(); 

            if (itemImage != null)
            {
                itemImage.sprite = item.icon;
            }

            if (SceneManager.GetActiveScene().name == "Final Scene") {
                itemButton.onClick.AddListener(() => SpawnItemInScene(item));
            }
        }
    }

    public void CheckInventoryUI() {
        string[] allowedScenes = { "SampleScene", "Final Scene" };

        GameObject inventoryPanel = GameObject.Find("Inventory");

        if (inventoryPanel != null){
            inventoryPanel.SetActive(System.Array.Exists(allowedScenes, scene => scene == SceneManager.GetActiveScene().name));
        }
    }

public void SpawnItemInScene(Item item) {
    GameObject spawnPoint = GameObject.FindWithTag(item.spawnPointTag);

    Vector3 spawnPosition = spawnPoint.transform.position;

    spawnPosition += new Vector3(0, 0, -2f);

    GameObject spawnedItem = new GameObject(item.itemName);
    spawnedItem.transform.position = spawnPosition;

    SpriteRenderer spriteRenderer = spawnedItem.AddComponent<SpriteRenderer>();
    spriteRenderer.sprite = item.icon; 

    spawnedItem.transform.localScale = new Vector3(0.4f, 0.4f, 1f);

    AudioSource audioSource = spawnedItem.AddComponent<AudioSource>();
    audioSource.clip = item.musicSound;
    audioSource.playOnAwake = false;

    BoxCollider2D collider = spawnedItem.AddComponent<BoxCollider2D>();
    collider.isTrigger = true;
    spawnedItem.AddComponent<OrbSound>().SetAudioSource(audioSource);

    Remove(item);
}

}
