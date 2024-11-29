using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    protected Model MineModel;
    protected View MineView;
    protected Rigidbody2D rb;
    protected Vector2 NewDirection;
    private void Awake()
    {
        MineModel = GetComponent<Model>();
        MineView = GetComponent<View>();
        rb = GetComponent<Rigidbody2D>();
        MineModel.OnDeath += Death;
        MineModel.OnHealthChange += MineView.UpdateHealth;
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
        rb.velocity = NewDirection.normalized * MineModel.Speed;
    }
}
