using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlantHints : MonoBehaviour
{
    public GameObject Hint1;
    public GameObject Hint2;
    public GameObject Hint3;
    public GameObject Hint4;

    public bool phase0;
    public bool phase1;
    public bool phase2;
    public bool phase3;

    public float animationDuration = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Watering")
        {
            Invoke("DisableAnimator", animationDuration);
        }
        if (other.tag == "Watering" && phase0)
        {
            Hint1.gameObject.SetActive(true);
        }
        if (other.tag == "Watering" && phase1)
        {
            Hint2.gameObject.SetActive(true);
        }
        if (other.tag == "Watering" && phase2)
        {
            Hint3.gameObject.SetActive(true);
        }
        if (other.tag == "Watering" && phase3)
        {
            Hint4.gameObject.SetActive(true);
        }
    }

    private void DisableAnimator()
    {
        if(Hint1.activeSelf)
        {
            Hint1.GetComponent<Animator>().enabled = false;
            Hint1.GetComponent<BoxCollider>().enabled = true;
            Hint1.GetComponent<XRGrabInteractable>().enabled = true;
            Hint1.GetComponent<Rigidbody>().isKinematic = false;
            Hint1.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Hint1.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
        if (Hint2.activeSelf)
        {
            Hint2.GetComponent<Animator>().enabled = false;
            Hint2.GetComponent<BoxCollider>().enabled = true;
            Hint2.GetComponent<XRGrabInteractable>().enabled = true;
            Hint2.GetComponent<Rigidbody>().isKinematic = false;
            Hint1.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Hint1.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
        if (Hint3.activeSelf)
        {
            Hint3.GetComponent<Animator>().enabled = false;
            Hint3.GetComponent<BoxCollider>().enabled = true;
            Hint3.GetComponent<XRGrabInteractable>().enabled = true;
            Hint3.GetComponent<Rigidbody>().isKinematic = false;
            Hint1.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Hint1.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
        if (Hint4.activeSelf)
        {
            Hint4.GetComponent<Animator>().enabled = false;
            Hint4.GetComponent<BoxCollider>().enabled = true;
            Hint4.GetComponent<XRGrabInteractable>().enabled = true;
            Hint4.GetComponent<Rigidbody>().isKinematic = false;
            Hint1.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Hint1.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }

    public void EnablePhase1()
    {
        phase1 = true;
    }
    public void EnablePhase2()
    {
        phase2 = true;
    }
    public void EnablePhase3()
    {
        phase3 = true;
    }

    public void DisablePhase0() 
    {
        phase0 = false;
    }
    public void DisablePhase1()
    {
        phase1 = false;
    }
    public void DisablePhase2()
    {
        phase2 = false;
    }
}
