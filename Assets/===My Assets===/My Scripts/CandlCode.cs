using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;

public class CandlCode : MonoBehaviour
{
    [Header("Candle Fire PP")]
    public ParticleSystem firePp1, firePp2, firePp3, firePp4, firePp5, firePp6, firePp7, firePp8;

    [Header("Win Data")]
    public PlayableDirector endTimeline;

    private int correctOrder = 0;
    private bool candle1, candle2, candle3, candle4, candle5, candle6, candle7;

    private void Start()
    {
        int order = correctOrder;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Candle1")
        {
            correctOrder = 1;
            candle1 = true;
        }
        if (other.tag == "Candle2" && candle1 == true)
        {
            correctOrder = 2;
            candle2 = true;
        }
        if (other.tag == "Candle3" && candle2 == true)
        {
            correctOrder = 3;
            candle3 = true;
        }
        if (other.tag == "Candle4" && candle3 == true)
        {
            correctOrder = 4;
            candle4 = true;
        }
        if (other.tag == "Candle5" && candle4 == true)
        {
            correctOrder = 5;
            candle5 = true;
        }
        if (other.tag == "Candle6" && candle5 == true)
        {
            correctOrder = 6;
            candle6 = true;
        }
        if (other.tag == "Candle7" && candle6 == true)
        {
            correctOrder = 7;
            candle7 = true;
        }
        if (other.tag == "Candle8" && candle7 == true)
        {
            correctOrder = 8;
            win();
        }
    }

    public void ResetOrder()
    {
        StartCoroutine(ResetDelay());
    }
    public IEnumerator ResetDelay()
    {
        yield return new WaitForSeconds(1.5f);
        correctOrder = 0;
        candle1 = false; candle2 = false; candle3 = false; candle4 = false; candle5 = false; candle6 = false; candle7 = false;
        firePp1.Stop(); firePp2.Stop(); firePp3.Stop(); firePp4.Stop(); firePp5.Stop(); firePp6.Stop(); firePp7.Stop(); firePp8.Stop();
    }

    public void win()
    {
            endTimeline.Play();
    }

    public void Checker1()
    {
        if(candle1 == false)
        {
            ResetOrder();
        }
    }
    public void Checker2()
    {
        if (candle1 == false || candle2 == false)
        {
            ResetOrder();
        }
    }
    public void Checker3()
    {
        if (candle1 == false || candle2 == false || candle3 == false)
        {
            ResetOrder();
        }
    }
    public void Checker4()
    {
        if (candle1 == false || candle2 == false || candle3 == false || candle4 == false)
        {
            ResetOrder();
        }
    }
    public void Checker5()
    {
        if (candle1 == false || candle2 == false || candle3 == false || candle4 == false || candle5 == false)
        {
            ResetOrder();
        }
    }
    public void Checker6()
    {
        if (candle1 == false || candle2 == false || candle3 == false || candle4 == false || candle5 == false || candle6 == false)
        {
            ResetOrder();
        }
    }
    public void Checker7()
    {
        if (candle1 == false || candle2 == false || candle3 == false || candle4 == false || candle5 == false || candle6 == false || candle7 == false)
        {
            ResetOrder();
        }
    }
}
