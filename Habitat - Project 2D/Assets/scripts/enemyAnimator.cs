using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAnimator : MonoBehaviour
{
    Animator _animator;
    enemy _enemy;
    hp _hp;
    // Start is called before the first frame update
    void Start()
    {
        _enemy = FindObjectOfType<enemy>();
        _hp = GetComponent<hp>();
        _animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("isAlive", _hp.isAlive);
        _animator.SetBool("inRange", _enemy.inRange);
        _animator.SetBool("canHit", _enemy.canHit);
        _animator.SetBool("isStun", _enemy.Stun);
    }
}
