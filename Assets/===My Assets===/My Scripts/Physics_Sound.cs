using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Put this script on a gameobject with a spatialized (local) audiosource - to enhance realism.

[RequireComponent(typeof(AudioSource))]
public class Physics_Sound : MonoBehaviour
{
    [SerializeField] private AudioClip bounceSound; 
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(bounceSound, GetVolumeBasedOnVelocity());
    }

    float GetVolumeBasedOnVelocity()
    {
        float speed = GetComponent<Rigidbody>().velocity.magnitude;
        float minVolume = 0.1f;
        float maxVolume = 1.0f;
        return Mathf.Clamp((speed / 10) * (maxVolume - minVolume) + minVolume, minVolume, maxVolume);
    }
}
