using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// play a sound from a random list of audio clips (you create in the Inspector).
// remember - the gameobject this script is placed on, must also have an AudioSource for this to work!

public class RandomSoundsTimer : MonoBehaviour
{
    public AudioClip[] audios;
    private int indexer;
    private AudioSource audioSource;
    private AudioClip audioClip;

    public float timePassed = 0f;

    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        audios[indexer] = audios[0];
        StartCoroutine(Timer());
    }

    public void PlayRandomSound()
    {
        indexer = Random.Range(0, audios.Length);
        audioClip = audios[indexer];
        audioSource.clip = audioClip;
        audioSource.Play();
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(timePassed);
        PlayRandomSound();
    }

}

