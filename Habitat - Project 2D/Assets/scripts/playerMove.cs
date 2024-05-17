using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class playerMove : MonoBehaviour
{
    attack _attack;
    Rigidbody2D rb;
    character_SO _basicValues;
    hp _hp;
    public float moveSpeed, jumpForce, gravityCorrection;
    public Vector2 moveDir;
    public float groundCheckDistance;
    public bool isGrounded;
    public LayerMask layer;


    // Start is called before the first frame update
    void Start()
    {
        _hp = GetComponent<hp>();
        _basicValues = GetComponent<hp>()._basicValues;
        rb = GetComponent<Rigidbody2D>();
        _attack = FindObjectOfType<attack>();
        moveSpeed = _basicValues.moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        gravity();
        if (_hp.isAlive && (!_attack.isAttacking))
        {
            move();
        }
        
        isGrounded = Physics2D.Raycast(transform.position + new Vector3(0, .05f, 0), Vector2.down, groundCheckDistance, layer);

        gravity();

    }
    public void gravity()
    {
        if (!isGrounded)
        {
            if (rb.velocity.y > 0)
            {
                rb.gravityScale = 1;
            }
            else
            {
                rb.gravityScale = gravityCorrection;
            }
        }
        else
        {
            rb.gravityScale = 1;
        }
    }
    public void move()
    {
        moveDir = new Vector2(Input.GetAxis("Horizontal"), 0);

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        transform.Translate(new Vector2(Mathf.Abs(moveDir.x), moveDir.y) * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && _hp.isAlive)
        {
            
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "animal")
        {
            //Physics.IgnoreCollision(collision.collider, gameObject.GetComponent<Collider>());
            
        }
    }
}
