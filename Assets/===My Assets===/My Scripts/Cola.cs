using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cola : MonoBehaviour
{
    [Header("Cola Data")]
    [SerializeField] float timer = 0;
    [SerializeField] float timeToBurp = 3;
    public RandomSounds burpAudio;
    private bool isDrinking;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Mouth")
        {
            isDrinking = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Mouth")
        {
            isDrinking = false;
            timer = 0;
        }
    }
    private void Update()
    {
        if(isDrinking)
        {
            timer += Time.deltaTime;
            if (timer >= timeToBurp)
            {
                burpAudio.PlayRandomSound();
                timer = 0;
            }
        }
    }
}
