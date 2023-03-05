using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCompontesswitch : MonoBehaviour
{
    public GameObject panelMain;
    public GameObject panelAero;
    public GameObject panelMotor;
    public GameObject panelChasis;
    public GameObject panelDurability;

    public void ChangePanel(int panelnumber)
    {
        /*if (panelnumber == 1) //main
        {
            panelMain.SetActive(true);
            panelAero.SetActive(false);
            panelMotor.SetActive(false);
            panelChasis.SetActive(false);
            panelDurability.SetActive(false);
        }
        else if (panelnumber == 2) //Aero
        {
            panelAero.SetActive(true);
            panelMain.SetActive(false);
            panelMotor.SetActive(false);
            panelChasis.SetActive(false);
            panelDurability.SetActive(false);
        }
        else if (panelnumber == 3) //Chasis
        {
            panelChasis.SetActive(true);
            panelAero.SetActive(false);
            panelMain.SetActive(false);
            panelMotor.SetActive(false);
            panelDurability.SetActive(false);
        }
        else if (panelnumber == 4) //Motor
        {
            panelMotor.SetActive(true);
            panelMain.SetActive(false);
            panelAero.SetActive(false);
            panelChasis.SetActive(false);
            panelDurability.SetActive(false);
        }
        else if (panelnumber == 5) //Durability
        {
            panelDurability.SetActive(true);
            panelMotor.SetActive(false);
            panelMain.SetActive(false);
            panelAero.SetActive(false);
            panelChasis.SetActive(false);
        }*/
        panelMain.SetActive(false);
        panelAero.SetActive(false);
        panelMotor.SetActive(false);
        panelChasis.SetActive(false);
        panelDurability.SetActive(false);
        switch (panelnumber)
        {
            case 1: panelMain.SetActive(true); break;
            case 2: panelAero.SetActive(true); break;
            case 3: panelMotor.SetActive(true); break;
            case 4: panelChasis.SetActive(true); break;
            case 5: panelDurability.SetActive(true); break;
        }
        
    }
}
