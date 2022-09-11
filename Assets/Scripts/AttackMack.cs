using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMack : MonoBehaviour
{
    public Animator anim;
    public void Mack()
    {
        anim.SetBool("Mack", true);
        StartCoroutine(EndAnimCoroutine());
    }

    private IEnumerator EndAnimCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("Mack", false);

    }
}
