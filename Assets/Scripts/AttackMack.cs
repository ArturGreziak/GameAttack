using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMack : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Mack()
    {
        anim.SetBool("Mack", true);
    }
}
