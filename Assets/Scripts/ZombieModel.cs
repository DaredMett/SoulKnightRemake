using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieModel : Model
{
    public static UIManager Instance;
    
    public override void Damage(int DamageAmount)
    {
        base.Damage(DamageAmount);
        print(HPCurrent);
    }
}
