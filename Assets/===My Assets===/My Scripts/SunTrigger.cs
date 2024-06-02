using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SunTrigger : MonoBehaviour
{
    [Header("Sun Trigger Data")]
    [SerializeField] int fireOrder = 0;
    [SerializeField] Material fireMat;
    public Color[] colorsList;
    public PlayQuickSound sunHitAudio;
    public TextMeshProUGUI hitOrder;
    public Light fireplaceLight;

    private void Awake()
    {
        fireMat.color = colorsList[0];
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Dart")
        {
            sunHitAudio.Play();
            fireOrder++;
            hitOrder.text = fireOrder.ToString();
            if(fireOrder == 1)
            {
                fireMat.color = colorsList[1];
                fireplaceLight.color = colorsList[1];
            }
            if (fireOrder == 2)
            {
                fireMat.color = colorsList[2];
                fireplaceLight.color = colorsList[2];
            }
            if (fireOrder == 3)
            {
                fireMat.color = colorsList[3];
                fireplaceLight.color = colorsList[3];
            }
            if (fireOrder == 4)
            {
                fireMat.color = colorsList[4];
                fireplaceLight.color = colorsList[4];
            }
            if (fireOrder == 5)
            {
                fireMat.color = colorsList[5];
                fireplaceLight.color = colorsList[5];
            }
            if (fireOrder == 6)
            {
                fireMat.color = colorsList[6];
                fireplaceLight.color = colorsList[6];
            }
            if (fireOrder == 7)
            {
                fireMat.color = colorsList[7];
                fireplaceLight.color = colorsList[7];
            }
            if (fireOrder == 8)
            {
                fireMat.color = colorsList[8];
                fireplaceLight.color = colorsList[8];
            }
            if(fireOrder == 9)
            {
                fireOrder = 1;
                fireMat.color = colorsList[1];
                fireplaceLight.color = colorsList[1];
                hitOrder.text = "1";
            }
        }
    }

}
