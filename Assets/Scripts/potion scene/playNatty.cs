using UnityEngine;

public class playNatty : MonoBehaviour
{
    public AudioSource voice;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void playVoice() {
        voice.Play();
    }
}
