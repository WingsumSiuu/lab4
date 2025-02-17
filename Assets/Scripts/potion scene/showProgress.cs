using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class showProgress : MonoBehaviour
{
    public TextMeshProUGUI progressText;
    public Slider slider;

    private void Update() {
        progressText.text = slider.value.ToString("0") +  "/" +  slider.maxValue.ToString();
    }
}
