using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public override void CalculateDirection()
    {
        NewDirection.y = Input.GetAxis("Vertical");
        NewDirection.x = Input.GetAxis("Horizontal");
    }
}
