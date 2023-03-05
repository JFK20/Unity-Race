using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepLoaded : MonoBehaviour
{
    [SerializeField] private CarSO car;
    [SerializeField] private TeamSO team;
    private CarSO car2;
    private TeamSO team2;
    // Start is called before the first frame update
    void Start()
    {
        car2 = car;
        team2 = team;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
