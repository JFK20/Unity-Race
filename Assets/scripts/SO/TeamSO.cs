using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TeamSO", menuName = "SO/SOTeam")]
public class TeamSO : ScriptableObject
{
    [SerializeField]
    private float baseMoney;
    private float money;

    public float Money { get => money; set => money = value; }

    private void OnEnable()
    {
        money = baseMoney;
    }

}
