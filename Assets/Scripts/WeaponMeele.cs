using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMeele : MonoBehaviour
{
    private Animator MineAnimator;
    private void Awake()
    {
        MineAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }
    public void Attack()
    {
        MineAnimator.SetTrigger("Hit");
    }
}
