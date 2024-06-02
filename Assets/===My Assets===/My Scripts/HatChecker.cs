using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatChecker : MonoBehaviour
{
    [Header("Which Socket")]
    [SerializeField] bool isCaptain;
    [SerializeField] bool isWitch;
    [SerializeField] bool isCowboy;

    [Header("Win Data")]
    public Rigidbody leftDoor;
    public Rigidbody rightDoor;
    public GameObject flashlight;
    public GameObject plantHints;
    public GameObject lockIcon;
    public Material unlocked;
    public AudioSource chestUnlock;

    public static bool correctCaptain = false;
    public static bool correctWitch = false;
    public static bool correctCowboy = false;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Captain" && isCaptain == true)
        {
            correctCaptain = true;
            Debug.Log("Captain is correct: " + correctCaptain);
        }
        if (other.tag == "Captain" && isCaptain != true)
        {
            correctCaptain = false;
        }

        if (other.tag == "Witch" && isWitch == true)
        {
            correctWitch = true;
            Debug.Log("Witch is correct: " + correctWitch);
        }
        if (other.tag == "Witch" && isWitch != true)
        {
            correctWitch = false;
        }

        if (other.tag == "Cowboy" && isCowboy == true)
        {
            correctCowboy = true;
            Debug.Log("Cowboy is correct: " + correctCowboy);
        }
        if (other.tag == "Cowboy" && isCowboy != true)
        {
            correctCowboy = false;
        }
    }
    public void WinChecker()
    {
        if(correctCaptain == true && correctWitch == true && correctCowboy == true)
        {
            leftDoor.isKinematic = false;
            rightDoor.isKinematic = false;
            flashlight.GetComponent<Flashlight>().enabled = true;
            lockIcon.GetComponent<MeshRenderer>().material = unlocked;
            plantHints.GetComponent<PlantHints>().EnablePhase2();
            plantHints.GetComponent<PlantHints>().DisablePhase1();
            chestUnlock.Play();
            Debug.Log("Cabinet is open!");
        }
    }
}
