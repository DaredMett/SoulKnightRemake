using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnTouch : MonoBehaviour
{
    public int DamageAmount = 10;
    public float CoolDown = 1;
    public float TimeSinceLastDamage;
    public void OnCollisionStay2D(Collision2D collision)
    {
        if(TimeSinceLastDamage >= CoolDown)
        {
            Model EnemyModel;
            EnemyModel = collision.gameObject.GetComponent<Model>();
            EnemyModel.Damage(DamageAmount);
            print(EnemyModel.HPCurrent);
            TimeSinceLastDamage = 0;
        }
    }
    public void Update()
    {
        TimeSinceLastDamage += Time.deltaTime;
    }
}
