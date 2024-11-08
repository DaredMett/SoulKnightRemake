using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Model MineModel;
    public View MineView;
    public Rigidbody2D rb;
    public Vector2 NewDirection;
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
        rb.velocity = NewDirection;
    }
}
