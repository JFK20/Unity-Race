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
        if (Panelnumber == 1)
        {
            panelAero.SetActive(false);
            //panelMotor.SetActive(false);
            panelChasis.SetActive(false);
            //panelDurability.SetActive(false);
            panelMain.SetActive(true);
        }
        else if (Panelnumber == 2)
        {
            panelAero.SetActive(true);
            panelMain.SetActive(false);
            //panelMotor.SetActive(false);
            panelChasis.SetActive(false);
            //panelDurability.SetActive(false);
        }
        else if (Panelnumber == 3)
        {
            panelAero.SetActive(false);
            panelMain.SetActive(false);
            panelChasis.SetActive(true);
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
