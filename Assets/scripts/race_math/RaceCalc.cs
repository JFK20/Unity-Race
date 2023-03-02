using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using TMPro;
using UnityEngine;


public class RaceCalc : MonoBehaviour
{
    private float[,] Map;
    [SerializeField]
    private CarSO CarMain;
    float time = 0;
    [SerializeField] 
    private TextMeshProUGUI resultText;
    // Start is called before the first frame update
    public void Calculate(float[,] mapinp,int height)
    {
        //Thread.Sleep(5000);
        Map = mapinp;
        print(Map);
        print(height);
        float result = Race(height);
        //Thread.Sleep(5000);
        resultText.text = "race length: " + result;
    }

    public float Race(int height)
    {
        for(int i=0; i < height; i++)
        {
            if (i == 0)
            {
                time += 1 - 0.05f * CarMain.Acceleration; //start
            }
            else if (Map[0, i] > 0.15 && Map[0,i-1] <= 0.15) //kurve zu grade
            {
                time += 1 -  0.015f * CarMain.Drag - 0.025f * CarMain.Acceleration - 0.02f *CarMain.Speed;
            }
            else if (Map[0, i] > 0.15 && Map[0, i-1] > 0.15) // grade zu grade
            {
                time += 1 -  0.02f * CarMain.Drag - 0.02f * CarMain.Acceleration - 0.025f *CarMain.Speed; 
            }
            else if (Map[0, i] <= 0.15 && Map[0, i-1] > 0.15) //grade zu kurve
            {
                time += 1 - 0.015f * CarMain.Grip - 0.02f * CarMain.Spring - 0.025f * CarMain.CarBreak;
            }
            else if (Map[0, i] <= 0.15 && Map[0, i-1] <= 0.15) //kurve zu kurve
            {
                time += 1 - 0.025f * CarMain.Grip - 0.02f * CarMain.Spring;
            }
        }
        return time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
