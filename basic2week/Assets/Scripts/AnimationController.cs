using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        // animationVariable = 0 IDLE animationVariable 1 = JUMP animationVariable 2 = ATTACK
        // animationVariable�� 012�� ++, 2����ũ�� 0

        if (animationVariable < 2)
            animationVariable++;
        else
            animationVariable = 0;

        animator.SetInteger("State", animationVariable);
    }
}
