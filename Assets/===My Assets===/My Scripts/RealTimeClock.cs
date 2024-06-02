using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTimeClock : MonoBehaviour
{
    [SerializeField] GameObject secondsDial;
    [SerializeField] GameObject minutesDial;
    [SerializeField] GameObject hoursDial;

    [SerializeField] float rotationOffset = 90;


    void Update()
    {
        DateTime currentTime = DateTime.Now;

        float secondsDegree = (currentTime.Second / 60f) * 360f;
        secondsDial.transform.localRotation = Quaternion.Euler(secondsDegree + rotationOffset, 0 , -90f);

        float minutesDegree = (currentTime.Minute / 60f) * 360f;
        minutesDial.transform.localRotation = Quaternion.Euler(minutesDegree + rotationOffset, 0, -90f);

        float hoursDegree = (currentTime.Hour / 12f) * 360f;
        hoursDial.transform.localRotation = Quaternion.Euler(hoursDegree + rotationOffset, 0, -90f);
    }
}
