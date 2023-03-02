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

    public void ChangePanel(int Panelnumber)
    {
        if (Panelnumber == 1) //main
        {
            panelMain.SetActive(true);
            panelAero.SetActive(false);
            panelMotor.SetActive(false);
            panelChasis.SetActive(false);
            panelDurability.SetActive(false);
        }
        else if (Panelnumber == 2) //Aero
        {
            panelAero.SetActive(true);
            panelMain.SetActive(false);
            panelMotor.SetActive(false);
            panelChasis.SetActive(false);
            panelDurability.SetActive(false);
        }
        else if (Panelnumber == 3) //Chasis
        {
            panelChasis.SetActive(true);
            panelAero.SetActive(false);
            panelMain.SetActive(false);
            panelMotor.SetActive(false);
            panelDurability.SetActive(false);
        }
        else if (Panelnumber == 4) //Motor
        {
            panelMotor.SetActive(true);
            panelMain.SetActive(false);
            panelAero.SetActive(false);
            panelChasis.SetActive(false);
            panelDurability.SetActive(false);
        }
        else if (Panelnumber == 5) //Durability
        {
            panelDurability.SetActive(true);
            panelMotor.SetActive(false);
            panelMain.SetActive(false);
            panelAero.SetActive(false);
            panelChasis.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
