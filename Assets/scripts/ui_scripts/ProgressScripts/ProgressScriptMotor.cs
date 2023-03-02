using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressScriptMotor : MonoBehaviour
{
    [SerializeField]
    private CarSO carMain;
    [SerializeField]
    private TeamSO teamMain;
    [SerializeField]
    private Slider motorBar;
    [SerializeField]
    private Button cheapMotorButton;
    [SerializeField]
    private Button expensiveMotorButton;
    [SerializeField]
    private TextMeshProUGUI motorStats;
    [SerializeField]
    private TextMeshProUGUI money;
    [SerializeField] 
    private float[] cheapValues;
    [SerializeField] 
    private float[] expensiveValues;
    
    public void MotorUpdate()
    {
        motorBar.value = carMain.Speed + carMain.Acceleration;
        motorStats.text = "speed: " + carMain.Speed + "\n" + "acceleration: " + carMain.Acceleration;
        money.text = "Money: " + teamMain.Money;

        if (carMain.Speed + carMain.Acceleration >= 10) 
        {
            cheapMotorButton.interactable= false;
            expensiveMotorButton.interactable= false;
        }
        if (teamMain.Money < expensiveValues[1]) expensiveMotorButton.interactable = false;
        if (teamMain.Money < cheapValues[1]) cheapMotorButton.interactable = false;

    }
    
    public void Expensive()
    {
        if (teamMain.Money >= expensiveValues[1])
        {
            carMain.Speed += expensiveValues[0];
            carMain.Acceleration += expensiveValues[0];
            teamMain.Money -= expensiveValues[1];
            MotorUpdate();
        }

    }
    public void Cheap()
    {
        if (teamMain.Money >= cheapValues[1])
        {
            carMain.Speed += cheapValues[0];
            carMain.Acceleration += cheapValues[0];
            teamMain.Money -= cheapValues[1];
            MotorUpdate();
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        MotorUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
