using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PutinTextChasis : MonoBehaviour
{
    [SerializeField]
    private CarSO CarMain;

    TextMeshProUGUI Stats;

    // Start is called before the first frame update
    void Start()
    {
        Stats = GetComponent<TextMeshProUGUI>();
        Stats.text = "Spring: " + CarMain.Spring;
    }

    // Update is called once per frame
    void Update()
    {
       Stats.text = "Spring: " + CarMain.Spring;
    }
}
