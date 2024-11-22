using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnTouch : MonoBehaviour
{
    public int DamageAmount = 10;
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.isTrigger)
        {
            return;
        }
        if (collision.gameObject.tag == tag)
        {
            return;
        }
        Model EnemyModel;
        EnemyModel = collision.gameObject.GetComponent<Model>();
        EnemyModel.Damage(DamageAmount);
    }
}
