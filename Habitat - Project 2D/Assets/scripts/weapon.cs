using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainFunctions;
public class weapon : MonoBehaviour
{
    attackManager _attackManager = new();
    Force _Force = new();
    enemy _enemy;
    // Start is called before the first frame update
    void Start()
    {
        _enemy = transform.parent.gameObject.GetComponent<enemy>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _attackManager.hpChange(other.gameObject, transform.parent.gameObject.GetComponent<enemy>().damage, valueChangeType.decrease);
            _Force.addForce(other.gameObject, transform.parent.gameObject.GetComponent<enemy>().pushbackForce, (other.gameObject.transform.position - transform.position));
        }
    }
}
