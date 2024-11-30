using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSystem : MonoBehaviour
{
    private Animator anim;
    public Attack_gauge attack_gauge;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (attack_gauge.attack == true)
        {
            anim.SetBool("Attack", true);
            attack_gauge.attack = false;
        }
    }
    public void ResetAttack()
    {
        anim.SetBool("Attack", false);
    }
}
