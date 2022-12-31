using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PutinTextAero : MonoBehaviour
{
    [SerializeField]
    private CarSO CarMain;

    TextMeshProUGUI Stats;

    // Start is called before the first frame update
    void Start()
    {
        Stats = GetComponent<TextMeshProUGUI>();
        Stats.text = "Drag: " + CarMain.Drag + "\n" + "Grip: " + CarMain.Grip;
    }

    // Update is called once per frame
    void Update()
    {
        Stats.text = "Drag: " + CarMain.Drag + "\n" + "Grip: " + CarMain.Grip;
    }
}
