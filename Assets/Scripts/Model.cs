using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Model : MonoBehaviour
{
    private int HPMax = 100;
    private int HPCurrent;
    private int HPMin = 0;
    public event Action OnDeath;
    public void Damage(int DamageAmount)
    {
        HPCurrent = HPCurrent - DamageAmount;
    }
    public void CheckHealth()
    {
        if (HPCurrent == 0)
        {
            OnDeath.Invoke();
        }
    }
}
