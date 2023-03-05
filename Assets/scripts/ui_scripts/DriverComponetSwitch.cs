using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DriverComponetSwitch : MonoBehaviour
{
    public GameObject panelMain;
    public GameObject panelPace;
    public GameObject panelExperience;
    public GameObject panelMotivation;
    public GameObject panelWare;

    public void ChangePanel(int panelNumber)
    {
        panelMain.SetActive(false);
        panelPace.SetActive(false);
        panelExperience.SetActive(false);
        panelMotivation.SetActive(false);
        panelWare.SetActive(false);
        switch (panelNumber)
        {
            case 0: panelMain.SetActive(true); break;
            case 1: panelPace.SetActive(true); break;
            case 2: panelExperience.SetActive(true); break;
            case 3: panelMotivation.SetActive(true); break;
            case 4: panelWare.SetActive(true); break;
            
        }
    }

}
