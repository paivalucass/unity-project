using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class move_character_script : MonoBehaviour
{
    private float horizontal;
    public float moveSpeed;
    private bool facingRight = true;
    public Animator animator;

    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        //float yinput = Input.GetAxis("y");
        print(xinput * moveSpeed);
        Vector2 moveSideways = new Vector2(xinput * moveSpeed * Time.deltaTime, body.velocity.y);
        Vector2 stop = new Vector2(0, 0);

        if (xinput > 0)
        {
            animator.SetFloat("Speed", moveSideways.x);
            body.velocity = moveSideways;
        }
        else if (xinput < 0)
        {
            animator.SetFloat("Speed", moveSideways.x);
            body.velocity = moveSideways;
        }
        else if (xinput == 0)
        {
            animator.SetFloat("Speed", moveSideways.x);
            body.velocity = stop;
        }
    }
}
