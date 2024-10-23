using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Model MineModel;
    private void Start()
    {
        MineModel.OnDeath += Death;
    }
    public void Death()
    {
        Destroy(gameObject);
    }
}
