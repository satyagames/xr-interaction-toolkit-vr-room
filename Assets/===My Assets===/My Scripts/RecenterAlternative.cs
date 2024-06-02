using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RecenterAlternative : MonoBehaviour
{
    public Transform Head;
    public Transform Origin; 
    public Transform Target;

    private void Start()
    {
        Invoke("Recenter", 1f);
    }
    [ContextMenu("Recenter")]
    public void Recenter()
    {
        Vector3 offset = Head.position - Origin.position;
        offset.y = 0;
        Origin.position = Target.position - offset;

        Vector3 targetForward = Target.forward;
        targetForward.y = 0;
        Vector3 cameraForward = Head.forward;
        cameraForward.y = 0;

        float angle = Vector3.SignedAngle(cameraForward, targetForward, Vector3.up);

        Origin.RotateAround(Head.position, Vector3.up, angle);
    }
}
