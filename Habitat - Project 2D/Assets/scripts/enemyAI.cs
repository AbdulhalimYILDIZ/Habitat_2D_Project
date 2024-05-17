using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    float chaseRange;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        chaseRange = FindObjectOfType<enemy>().chaseRange;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(player.transform.position.x,transform.position.y,0));
        if (Vector2.Distance(transform.position, player.transform.position) > chaseRange)
        {
            transform.Translate(new Vector3(0,0,moveSpeed * Time.deltaTime));
        }
    }
}
