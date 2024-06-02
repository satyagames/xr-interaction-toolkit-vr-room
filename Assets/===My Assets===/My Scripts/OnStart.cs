using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    public AudioListener mainListener;
    private void Start()
    {
        mainListener.enabled = false;
        Invoke("EnableListener", 0.25f);
    }
    public void EnableListener()
    {
        mainListener.enabled = true;
    }
}
