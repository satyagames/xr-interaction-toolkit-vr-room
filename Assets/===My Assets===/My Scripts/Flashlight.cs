using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Flashlight : XRGrabInteractable
{
    [Header("Flashlight Data")]
    public Light spotlight;
    public Transform beamOrigin;
    public Animator paintingOutline;
    public GameObject leftSocket;

    [Header("Flashlight Haptics")]
    public float power = 0.25f;
    public float duration = 0.1f;

    private XRBaseController m_Controller;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        var controllerInteractor = args.interactorObject as XRBaseControllerInteractor;
        m_Controller = controllerInteractor.xrController;
    }

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);
        m_Controller.SendHapticImpulse(0.75f, 0.1f);
    }
    private void ScanForObjects()
    {
        RaycastHit hit;
        Vector3 worldHit = beamOrigin.transform.position + beamOrigin.transform.forward * 100.0f;

        if (Physics.Raycast(beamOrigin.transform.position, beamOrigin.transform.forward, out hit) && hit.collider.gameObject.tag == "Outline")
        {
            worldHit = hit.point;

            paintingOutline.SetTrigger("Light");
            leftSocket.GetComponent<XRSocketInteractor>().enabled = true;
        }
    }
    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        if (spotlight.gameObject.activeSelf)
        {
            ScanForObjects();
        }
    }
}
