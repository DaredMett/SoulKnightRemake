using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public override void CalculateMove()
    {
        NewVelocity.y = Input.GetAxis("Vertical");
        NewVelocity.x = Input.GetAxis("Horizontal");
    }
}
