using UnityEngine;

public class OrbSound : MonoBehaviour
{
    private AudioSource audioSource;

    public void SetAudioSource(AudioSource source) {
        audioSource = source;
    }

    private void OnMouseDown() {
        if (audioSource != null) {
            audioSource.Play();
        }
    }
}
