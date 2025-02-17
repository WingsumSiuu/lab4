using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Transform originalParent;
    private Vector2 originalPosition;

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData) {
        originalParent = transform.parent; 
        originalPosition = transform.position;
        transform.SetParent(originalParent.parent); 
        canvasGroup.blocksRaycasts = false;
        Debug.Log("OnBeginDrag" + gameObject.name);
    }

    public void OnDrag(PointerEventData eventData) {
        Debug.Log("OnDrag" + gameObject.name);
        rectTransform.position = Input.mousePosition; 
    }

    public void OnEndDrag(PointerEventData eventData) {
        canvasGroup.blocksRaycasts = true; 

        if (transform.parent == originalParent.parent) 
        {
            transform.SetParent(originalParent);  
            transform.position = originalPosition; 
        }

        Debug.Log("OnEndDrag" + gameObject.name);
    }

    public void onPointerDown(PointerEventData evenData) {
        Debug.Log("OnPointerDown" + gameObject.name);
    }
}
