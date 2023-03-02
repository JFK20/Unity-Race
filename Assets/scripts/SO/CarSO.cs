using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "CarSO", menuName = "SO/SOCar")]

public class CarSO : ScriptableObject
{
    [SerializeField]
    private float basespeed;
    private float speed;//Motor
    [SerializeField]
    private float baseacceleration;
    private float acceleration;//Motor
    [SerializeField]
    private float basemotorDurability;
    private float motorDurability;//Motor
    [SerializeField]
    private float basespring;
    private float spring;//Chasis
    [SerializeField] 
    private float basecarbreak;
    private float carbreak; //Chasis
    [SerializeField]
    private float basechasisDurability;
    private float chasisDurability;//Chasis
    [SerializeField]
    private float basegrip;
    private float grip;//Aero
    [SerializeField]
    private float basedrag;
    private float drag;//Aero
    [SerializeField]
    private float baseaeroDurability;
    private float aeroDurability;//Aero

    public float Speed { get => speed; set => speed = value; }
    public float Acceleration { get => acceleration; set => acceleration = value; }
    public float MotorDurability { get => motorDurability; set => motorDurability = value; }
    public float Spring { get => spring; set => spring = value; }
    public float ChasisDurability { get => chasisDurability; set => chasisDurability = value; }
    public float Grip { get => grip; set => grip = value; }
    public float Drag { get => drag; set => drag = value; }
    public float AeroDurability { get => aeroDurability; set => aeroDurability = value; }
    public float CarBreak { get => carbreak; set => carbreak = value; }
    private void Awake()
    {
        speed = basespeed;
        acceleration = baseacceleration;
        motorDurability= basemotorDurability;
        spring = basespring;
        chasisDurability = basechasisDurability;
        grip= basegrip;
        drag= basedrag;
        aeroDurability= baseaeroDurability;
        carbreak = basecarbreak;
    }
}
