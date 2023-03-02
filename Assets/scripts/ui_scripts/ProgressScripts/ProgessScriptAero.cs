using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ProgessScriptAero : MonoBehaviour
{
    [SerializeField]
    private CarSO carMain;
    [SerializeField]
    private TeamSO teamMain;
    [SerializeField]
    private Slider aeroBar;
    [SerializeField]
    private Button cheapAeroButton;
    [SerializeField]
    private Button expensiveAeroButton;
    [SerializeField]
    private TextMeshProUGUI aeroStats;
    [SerializeField]
    private TextMeshProUGUI money;
    [SerializeField] 
    private float[] cheapValues;
    [SerializeField] 
    private float[] expensiveValues;

    public void AeroUpdate()
    {
        aeroBar.value = carMain.Drag + carMain.Grip;
        aeroStats.text = "Drag: " + carMain.Drag + "\n" + "Grip: " + carMain.Grip;
        money.text = "Money: " + teamMain.Money;

        if (carMain.Drag + carMain.Grip >= 10) 
        {
            cheapAeroButton.interactable= false;
            expensiveAeroButton.interactable= false;
        }
        if (teamMain.Money < expensiveValues[1]) expensiveAeroButton.interactable = false;
        if (teamMain.Money < cheapValues[1]) cheapAeroButton.interactable = false;

    }

    public void Expensive()
    {
        if (teamMain.Money >= expensiveValues[1])
        {
            carMain.Drag += expensiveValues[0];
            carMain.Grip += expensiveValues[0];
            teamMain.Money -= expensiveValues[1];
            AeroUpdate();
        }
    }
    public void Cheap()
    {
        if (teamMain.Money >= cheapValues[1])
        {
            carMain.Drag += cheapValues[0];
            carMain.Grip += cheapValues[0];
            teamMain.Money -= cheapValues[1];
            AeroUpdate();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    // Start is called before the first frame update
    void Start()
    {
        AeroUpdate();
    }
}
