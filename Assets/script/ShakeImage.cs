using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeImage : MonoBehaviour
{
    public Animator animator;

    private void OnMouseEnter()
    {
        animator.SetTrigger("Shake");
    }

    private void OnMouseExit()
    {
        animator.ResetTrigger("Shake");
    }
}
