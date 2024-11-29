using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class View : MonoBehaviour
{
    private Animator MineAnimator;
    private Rigidbody2D rb;
    private SpriteRenderer spRender;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MineAnimator = GetComponent<Animator>();
        spRender = GetComponent<SpriteRenderer>();
        UIManager.Instance.AskForSlider(this.gameObject);
    }
    public void WalkAnimatorOn()
    {
        MineAnimator.SetBool("Walk", true);
    }
    public void WalkAnimatorOff()
    {
        MineAnimator.SetBool("Walk", false);
    }
    public void Update()
    {
        if (rb.velocity.magnitude > 0)
        {
            WalkAnimatorOn();
        }
        else
        {
            WalkAnimatorOff();
        }
        if (rb.velocity.x < -0.1f)
        {
            spRender.flipX = true;
        }
        if(rb.velocity.x > 0.1f)
        {
            spRender.flipX= false;
        }
    }
    public virtual void UpdateHealth(int health)
    {
        
    }
}
