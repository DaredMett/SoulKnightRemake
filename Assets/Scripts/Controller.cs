using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Model MineModel;
    public View MineView;
    public Rigidbody2D rb;
    public Vector2 NewVelocity;
    private void Start()
    {
        MineModel.OnDeath += Death;
    }
    public void Death()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        CalculateMove();
        Move();
    }
    public virtual void CalculateMove()
    {
        
    }

    public void Move()
    {
        rb.velocity = NewVelocity;
    }
}
