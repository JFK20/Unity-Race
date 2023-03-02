using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressScriptChassis : MonoBehaviour
{
    
    [SerializeField]
    private CarSO carMain;
    [SerializeField]
    private TeamSO teamMain;
    [SerializeField]
    private Slider chassisBar;
    [SerializeField]
    private Button cheapChassisButton;
    [SerializeField]
    private Button expensiveChassisButton;
    [SerializeField]
    private TextMeshProUGUI chassisStats;
    [SerializeField]
    private TextMeshProUGUI money;
    [SerializeField] 
    private float[] cheapValues;
    [SerializeField] 
    private float[] expensiveValues;
    
    public void ChassisUpdate()
    {
        chassisBar.value = carMain.Spring + carMain.CarBreak;
        chassisStats.text = "Spring: " + carMain.Spring + "\n" + "Breaks: " + carMain.CarBreak;
        money.text = "Money: " + teamMain.Money;

        if (carMain.Spring + carMain.CarBreak >= 10) 
        {
            cheapChassisButton.interactable= false;
            expensiveChassisButton.interactable= false;
        }
        if (teamMain.Money < expensiveValues[1]) expensiveChassisButton.interactable = false;
        if (teamMain.Money < cheapValues[1]) cheapChassisButton.interactable = false;
    }
    
    public void Expensive()
    {
        if (teamMain.Money >= expensiveValues[1])
        {
            carMain.CarBreak += expensiveValues[0];
            carMain.Spring += expensiveValues[0];
            teamMain.Money -= expensiveValues[1];
            ChassisUpdate();
        }
    }
    public void Cheap()
    {
        if (teamMain.Money >= cheapValues[1])
        {
            carMain.CarBreak += cheapValues[0];
            carMain.Spring += cheapValues[0];
            teamMain.Money -= cheapValues[1];
            ChassisUpdate();
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ChassisUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
