using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Model : MonoBehaviour
{
    public float Speed = 3.0f;
    private int HPMax = 100;
    public string MineTag;
    public int HPCurrent;
    private int HPMin = 0;
    public event Action OnDeath;
    private void Awake()
    {
        HPCurrent = HPMax;
    }
    public virtual void Damage(int DamageAmount)
    {
        HPCurrent = HPCurrent - DamageAmount;
        CheckHealth();
    }
    public void CheckHealth()
    {
        if (HPCurrent <= 0)
        {
            OnDeath.Invoke();
        }
    }
}
