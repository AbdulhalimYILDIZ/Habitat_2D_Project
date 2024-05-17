using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catMove : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(5, 7);
        Physics2D.IgnoreLayerCollision(6, 8);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed*Time.deltaTime,0,0);
        
    }
}
