using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorController : MonoBehaviour
{
    Animator anim;
    attack _attack;
    hp _hp;
    playerMove _playerMove;
    private void Awake()
    {
        _playerMove = FindObjectOfType<playerMove>();
        _hp = FindObjectOfType<hp>();
        _attack = FindObjectOfType<attack>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (_hp.isAlive)
        {
            anim.SetBool("att_1", Input.GetKeyDown(KeyCode.Mouse0));
            anim.SetBool("att_2", Input.GetKeyDown(KeyCode.Mouse1));
            anim.SetBool("attacking", _attack.isAttacking);
            anim.SetBool("reAttack", _attack.reAttack);
            anim.SetBool("jump", Input.GetKeyDown(KeyCode.Space));
            anim.SetBool("isGrounded", _playerMove.isGrounded);
            anim.SetFloat("moving", Input.GetAxis("Horizontal"));
        }
            anim.SetBool("isAlive", _hp.isAlive);
    }

}
