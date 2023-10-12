using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun Data", menuName = "Gun Data", order = 52)]

public class GunData : ScriptableObject
{   

    [SerializeField]
    private string gunName;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int cost;
    [SerializeField]
    private int damage;

    public string GunName
    {
        get
        {
            return gunName;
        }
        set
        {
            gunName = value;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
        set
        {
            description = value;
        }
    }

    public Sprite Icon
    {
        get
        {
            return icon;
        }
        set
        {
            icon = value;
        }
    }

    public int Cost
    {
        get
        {
            return cost;
        }
        set
        {
            cost = value;
        }
    }

    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
}
