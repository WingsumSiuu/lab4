using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// https://www.youtube.com/watch?v=UCAo-uyb94c

public class floatingslider : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private void Awake() {
        slider = gameObject.GetComponent<Slider>();
    }

    public void addProgress(float currentValue) {
        slider.value += currentValue;
    }

    private void Update() {
        if (slider.value >= slider.maxValue) {
            SceneManager.LoadScene(4);
        }
    }
}
