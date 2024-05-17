using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class enemy : MonoBehaviour
{
    animatorController _animController;
    GameObject target;
    character_SO _basicValues;
    public float chaseRange, hitRange;
    public bool inRange,canHit,Stun;
    public int damage;
    public float pushbackForce;
    
    // Start is called before the first frame update
    void Start()
    {
        _basicValues = GetComponent<hp>()._basicValues;
        Stun = false;
        target = GameObject.FindWithTag("Player");
        _animController = GetComponent<animatorController>();
        chaseRange = _basicValues.chaseDistance;
        hitRange = _basicValues.hitDistance;
        pushbackForce = _basicValues.pushbackForce;
        damage = _basicValues.damage;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector2.Distance(transform.position,target.transform.position)<chaseRange)
        {
            inRange = true;
        }
        else
        {
            inRange = false;
        }

        if (Vector2.Distance(transform.position, target.transform.position) < hitRange)
        {
            canHit = true;
        }
        else
        {
            canHit = false;
        }

    }

    public void onDeath()
    {
        //_animController
    }
}
