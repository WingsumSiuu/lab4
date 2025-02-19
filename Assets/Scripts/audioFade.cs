using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Coroutine/WaitForSeconds documentation
// https://docs.unity3d.com/6000.0/Documentation/ScriptReference/WaitForSeconds.html

public class audioFade : MonoBehaviour
{
    private AudioSource song;
    // stops player from walking too far before music cuts off
    public GameObject block;
    // darkens screen for a second when music stops 
    public GameObject darkPanel;
    // stop buddies dancing animations + change speech bubbles
    public Animator buddy1;
    public Animator buddy2;
    public GameObject buddy1pre;
    public GameObject buddy1post;
    public GameObject buddy2pre;
    public GameObject buddy2post;
    public GameObject welcomepre;
    public GameObject welcomepost;
    public GameObject orbpre;
    public GameObject orbpost;
    public GameObject orbs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        song = GetComponent<AudioSource>();
        StartCoroutine(playSong());
    }

    IEnumerator playSong() {
        // playing for x seconds (change as fit)
        song.Play();
        yield return new WaitForSeconds(15);
        buddy1.SetBool("isDancing", false);
        buddy2.SetBool("isDancing", false);
        buddy1pre.SetActive(false);
        buddy2pre.SetActive(false);
        buddy1post.SetActive(true);
        buddy2post.SetActive(true);
        welcomepre.SetActive(false);
        orbpre.SetActive(false);
        welcomepost.SetActive(true);
        orbpost.SetActive(true);
        song.Stop();
        block.SetActive(false);
        orbs.SetActive(false);
        darkPanel.SetActive(true);
        yield return new WaitForSeconds(1);
        darkPanel.SetActive(false);
    }
}
