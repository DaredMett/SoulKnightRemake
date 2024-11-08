using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Model MineModel;
    private View MineView;
    private Rigidbody2D rb;
    [HideInInspector]public Vector2 NewDirection;
    public float Speed = 3.0f;
    private void Awake()
    {
        MineModel = GetComponent<Model>();
        MineView = GetComponent<View>();
        rb = GetComponent<Rigidbody2D>();
        MineModel.OnDeath += Death;
    }
    public void Death()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        CalculateDirection();
        Move();
    }
    public virtual void CalculateDirection()
    {
        
    }

    public void Move()
    {
        rb.velocity = NewDirection.normalized * Speed;
    }
}
