using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Stat : MonoBehaviour
{
    [SerializeField] private float maxHp = 100;
    [SerializeField] private float maxMp = 100;
    
    [SerializeField] private float currentHp = 100;
    [SerializeField] private float currentMp = 100;

    [SerializeField] private HPBar hpBar;
    public float MaxHp
    {
        get => maxHp;
        set => maxHp = value;
    }

    public float MaxMp
    {
        get => maxMp;
        set => maxMp = value;
    }

    public float CurrentHp
    {
        get => currentHp;
        set
        {
            currentHp = Mathf.Clamp(value, 0, maxHp);
            hpBar.CurrentHpValue = currentHp;
        }
    }

    public float CurrentMp
    {
        get => currentMp;
        set
        {
            currentMp = Mathf.Clamp(value, 0, maxMp);
        }
    }

    public void SetHp(float amount)
    {
        CurrentHp = amount;
    }

    protected void InitHpBar()
    {
        hpBar.CurrentHpValue = CurrentHp;
        hpBar.MaxHpValue = MaxHp;
    }
}
