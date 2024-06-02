using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleAnim : MonoBehaviour
{
    public GameObject Reticle;
    float rotation = 0;
    [SerializeField] float addedRotation = 45f;

    [SerializeField] private float scaleSpeed = 0.1f;
    [SerializeField] private float maxScale = 1.5f;
    [SerializeField] private float minScale = 1f;

    private bool isScalingUp = true;


    void Update()
    {
        rotation = rotation + addedRotation * Time.deltaTime;
        Reticle.transform.localRotation = Quaternion.Euler(0, rotation, 0);

        if (isScalingUp)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x >= maxScale)
            {
                isScalingUp = false;
            }
        }
        else
        {
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x <= minScale)
            {
                isScalingUp = true;
            }
        }
    }
}

