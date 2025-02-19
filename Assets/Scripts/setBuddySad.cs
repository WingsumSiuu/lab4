using UnityEngine;

public class setBuddySad : MonoBehaviour
{
    // in walkToPutOrbs scene, play sad animation
    public Animator buddy2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buddy2.Play("sad2 part2");
    }
}
