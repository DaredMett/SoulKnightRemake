using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemyController : Controller
{
    private Vector3 TargetPos;
    private int DamageAmount = 10;
    private void Start()
    {
        TargetPos = transform.position;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
         TargetPos = collision.transform.position;
        }
    }
    public override void CalculateDirection()
    {
        NewDirection = TargetPos - transform.position;
    }
}
