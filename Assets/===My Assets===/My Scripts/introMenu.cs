using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class introMenu : MonoBehaviour
{
    public MeshRenderer primaryButtonLeft;
    public MeshRenderer primaryButtonRight;
    public MeshRenderer secondaryButtonLeft;
    public MeshRenderer secondaryButtonRight;
    public MeshRenderer GrabLeft;
    public MeshRenderer GrabRight;
    public MeshRenderer TriggerLeft;
    public MeshRenderer TriggerRight;
    public MeshRenderer JoystickLeft;
    public MeshRenderer JoystickRight;

    public Material glowMAT;
    public Material normalMAT;

    public GameObject backButton;
    public GameObject creditsButton;
    public TextMeshProUGUI nextButtonText;



    [SerializeField] int page = 1;

    public void NextPage()
    {
        page++;
        if (page == 1)
        {
            backButton.SetActive(false);
            creditsButton.SetActive(true);
            primaryButtonLeft.material = glowMAT;
            primaryButtonRight.material = glowMAT;
            secondaryButtonLeft.material = normalMAT;
            secondaryButtonRight.material = normalMAT;
            GrabLeft.material = normalMAT;
            GrabRight.material = normalMAT;
            TriggerLeft.material = glowMAT;
            TriggerRight.material = glowMAT;
            JoystickLeft.material = normalMAT;
            JoystickRight.material = normalMAT;
        }
        if(page == 2)
        {
            backButton.SetActive(true);
            creditsButton.SetActive(false);
            primaryButtonLeft.material = normalMAT;
            primaryButtonRight.material = normalMAT;
            secondaryButtonLeft.material = normalMAT;
            secondaryButtonRight.material = normalMAT;
            GrabLeft.material = glowMAT;
            GrabRight.material = glowMAT;
            TriggerLeft.material = glowMAT;
            TriggerRight.material = glowMAT;
            JoystickLeft.material = normalMAT;
            JoystickRight.material = normalMAT;
        }
        if (page == 3)
        {
            primaryButtonLeft.material = glowMAT;
            primaryButtonRight.material = glowMAT;
            secondaryButtonLeft.material = normalMAT;
            secondaryButtonRight.material = normalMAT;
            GrabLeft.material = glowMAT;
            GrabRight.material = glowMAT;
            TriggerLeft.material = normalMAT;
            TriggerRight.material = normalMAT;
            JoystickLeft.material = glowMAT;
            JoystickRight.material = glowMAT;
        }
        if (page == 4)
        {
            nextButtonText.text = "Next";
            primaryButtonLeft.material = normalMAT;
            primaryButtonRight.material = normalMAT;
            secondaryButtonLeft.material = normalMAT;
            secondaryButtonRight.material = normalMAT;
            GrabLeft.material = normalMAT;
            GrabRight.material = normalMAT;
            TriggerLeft.material = normalMAT;
            TriggerRight.material = normalMAT;
            JoystickLeft.material = glowMAT;
            JoystickRight.material = glowMAT;
        }
        if (page == 5)
        {
            nextButtonText.text = "OK";
            primaryButtonLeft.material = normalMAT;
            primaryButtonRight.material = normalMAT;
            secondaryButtonLeft.material = glowMAT;
            secondaryButtonRight.material = glowMAT;
            GrabLeft.material = normalMAT;
            GrabRight.material = normalMAT;
            TriggerLeft.material = normalMAT;
            TriggerRight.material = normalMAT;
            JoystickLeft.material = normalMAT;
            JoystickRight.material = normalMAT;
        }
    }
    public void PreviusPage()
    {
        page--;
        if (page == 1)
        {
            backButton.SetActive(false);
            creditsButton.SetActive(true);
            primaryButtonLeft.material = glowMAT;
            primaryButtonRight.material = glowMAT;
            secondaryButtonLeft.material = normalMAT;
            secondaryButtonRight.material = normalMAT;
            GrabLeft.material = normalMAT;
            GrabRight.material = normalMAT;
            TriggerLeft.material = glowMAT;
            TriggerRight.material = glowMAT;
            JoystickLeft.material = normalMAT;
            JoystickRight.material = normalMAT;
        }
        if (page == 2)
        {
            backButton.SetActive(true);
            creditsButton.SetActive(false);
            primaryButtonLeft.material = normalMAT;
            primaryButtonRight.material = normalMAT;
            secondaryButtonLeft.material = normalMAT;
            secondaryButtonRight.material = normalMAT;
            GrabLeft.material = glowMAT;
            GrabRight.material = glowMAT;
            TriggerLeft.material = glowMAT;
            TriggerRight.material = glowMAT;
            JoystickLeft.material = normalMAT;
            JoystickRight.material = normalMAT;
        }
        if (page == 3)
        {
            primaryButtonLeft.material = normalMAT;
            primaryButtonRight.material = normalMAT;
            secondaryButtonLeft.material = normalMAT;
            secondaryButtonRight.material = normalMAT;
            GrabLeft.material = glowMAT;
            GrabRight.material = glowMAT;
            TriggerLeft.material = normalMAT;
            TriggerRight.material = normalMAT;
            JoystickLeft.material = glowMAT;
            JoystickRight.material = glowMAT;
        }
        if (page == 4)
        {
            primaryButtonLeft.material = normalMAT;
            primaryButtonRight.material = normalMAT;
            secondaryButtonLeft.material = normalMAT;
            secondaryButtonRight.material = normalMAT;
            GrabLeft.material = normalMAT;
            GrabRight.material = normalMAT;
            TriggerLeft.material = normalMAT;
            TriggerRight.material = normalMAT;
            JoystickLeft.material = glowMAT;
            JoystickRight.material = glowMAT;
        }
        if (page == 5)
        {
            nextButtonText.text = "OK";
            primaryButtonLeft.material = normalMAT;
            primaryButtonRight.material = normalMAT;
            secondaryButtonLeft.material = glowMAT;
            secondaryButtonRight.material = glowMAT;
            GrabLeft.material = normalMAT;
            GrabRight.material = normalMAT;
            TriggerLeft.material = normalMAT;
            TriggerRight.material = normalMAT;
            JoystickLeft.material = normalMAT;
            JoystickRight.material = normalMAT;
        }
    }
}
