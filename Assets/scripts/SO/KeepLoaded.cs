using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepLoaded : MonoBehaviour
{
    [SerializeField] private CarSO car;

    private CarSO car2;
    // Start is called before the first frame update
    void Start()
    {
        car2 = car;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
