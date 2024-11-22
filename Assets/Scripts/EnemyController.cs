using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemyController : Controller
{
    private Vector3 TargetPos;
    private Vector3 DirectionToPlayer;
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
        DirectionToPlayer = TargetPos - transform.position;
        if (DirectionToPlayer.magnitude < 1f)
        {
            NewDirection = DirectionToPlayer;
        }
        else
        {
            NewDirection = Vector3.zero;
        }
    }
}
