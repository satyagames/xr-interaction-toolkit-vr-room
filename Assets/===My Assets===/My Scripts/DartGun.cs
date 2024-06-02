using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DartGun : XRGrabInteractable
{
    [Header("Dart Gun Haptics")]
    public float power = 0.75f;
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
}
