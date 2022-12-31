using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ProgessScript : MonoBehaviour
{
    public static Slider[] Bars;
    public static Slider AeroBar;

    public static Button[] Buttons;
    public static Button[] Buttonsaero = new Button[2];

    [SerializeField]
    private CarSO CarMain;
    [SerializeField]
    private TeamSO TeamMain;

    public void IncreaseAero(float Aero)
    {
        CarMain.Drag += Aero;
        CarMain.Grip += Aero;
    }

    public void Cost(float cost)
    {
        TeamMain.Money -= cost; 
    }

    // Start is called before the first frame update
    void Start()
    {
        //Bar = GameObject.Find("ProgressBar");
        Bars = GameObject.FindObjectsOfType<Slider>();
        for (int i = 0;i < Bars.Length;i++)
        {
            if(Bars[i].name.Equals("ProgessBarAero")) 
                {
                AeroBar = Bars[i];
            }
        }
        
        Buttons= GameObject.FindObjectsOfType<Button>();
        int j = 0;
        for (int i = 0;i < Buttons.Length;i++)
        {
            if (Buttons[i].CompareTag("AeroButton"))
            {
                Buttonsaero[j]= Buttons[i];
                j++;
            }
        }

    }

    public void AeroUpdate()
    {
        if (AeroBar != null)
        {
            AeroBar.value = CarMain.Drag + CarMain.Grip;
        }

        if (CarMain.Drag + CarMain.Grip >= 10) 
        {
            Buttonsaero[0].interactable= false;
            Buttonsaero[1].interactable= false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        AeroUpdate();
    }
}
