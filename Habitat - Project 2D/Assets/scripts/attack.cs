using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainFunctions;

public class attack : MonoBehaviour
{
    character_SO _basicValues;
    Force _Force = new ();
    attackManager _attackManager = new attackManager();
    public int damage;
    public bool isAttacking,reAttack;
    public float pushBackForce;
    // Start is called before the first frame update
    void Start()
    {
        _basicValues = GetComponent<hp>()._basicValues;
        reAttack = false;
        damage = _basicValues.damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {        
        if(other.gameObject.tag=="enemy")
        {
            _attackManager.hpChange(other.gameObject,damage,valueChangeType.decrease);
            _Force.addForce(other.gameObject, pushBackForce,(other.gameObject.transform.position-transform.position));
        }
    }
    public void canCombo()
    {
        reAttack = true;
    }
    public void attackFalse()
    {
        isAttacking = false;
        reAttack = false;

    }
    public void attackTrue()
    {
        isAttacking = true;
    }
}
