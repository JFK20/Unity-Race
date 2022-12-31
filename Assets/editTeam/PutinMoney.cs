using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PutinMoney : MonoBehaviour
{
    [SerializeField]
    private TeamSO TeamMain;

    TextMeshProUGUI money;

    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<TextMeshProUGUI>();
        money.text = "Money: " + TeamMain.Money;
    }

    // Update is called once per frame
    void Update()
    {
       money.text = "Money: " + TeamMain.Money;
    }
}
