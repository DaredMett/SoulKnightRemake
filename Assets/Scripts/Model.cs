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
    public float InvisibilityCoolDown = 1;
    public float TimeSinceLastDamage = 5;
    private void Awake()
    {
        HPCurrent = HPMax;
    }
    public virtual void Damage(int DamageAmount)
    {
        if (TimeSinceLastDamage >= InvisibilityCoolDown)
        {
            HPCurrent = HPCurrent - DamageAmount;
            CheckHealth();
            TimeSinceLastDamage = 0;
            print(HPCurrent  + name);
        }
    }
    public void CheckHealth()
    {
        if (HPCurrent <= 0)
        {
            OnDeath.Invoke();
        }
    }
    public void Update()
    {
        TimeSinceLastDamage += Time.deltaTime;
    }
}
