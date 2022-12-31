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

    private void OnEnable()
    {
        speed = basespeed;
        acceleration = baseacceleration;
        motorDurability= basemotorDurability;
        spring = basespring;
        chasisDurability = basechasisDurability;
        grip= basegrip;
        drag= basedrag;
        aeroDurability= baseaeroDurability;
    }
}


/*public class Motor : MonoBehaviour 
{
    public float speed;
    public float accelartion;
    public float durability;

    public Motor(float speed,float accelartion, float durability)
    {
        this.speed = speed;
        this.accelartion = accelartion;
        this.durability = durability;
    }

}

public class Chasis : MonoBehaviour 
{
    public float durability;
    public float spring;

    public Chasis(float durability,float spring)
    {
        this.durability = durability;
        this.spring = spring;
    }

}

public class Aero : MonoBehaviour 
{
    private float grip;
    private float drag;
    private float durability;

    public float Drag { get => drag; set => drag = value; }
    public float Grip { get => grip; set => grip = value; }
    public float Durability { get => durability; set => durability = value; }

    public Aero(float grip,float drag,float durability)
    {
        this.Grip = grip;
        this.Drag = drag;
        this.Durability = durability;
    }
}*/
