using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackKenji : MonoBehaviour
{
    public Animator anim;
    public void Kenji()
    {
        anim.SetBool("Kenji", true);
        StartCoroutine(EndAnimCoroutine());
    }

    private IEnumerator EndAnimCoroutine()
    {
        yield return new WaitForSeconds(0.02f);
        anim.SetBool("Kenji", false);

    }
}
