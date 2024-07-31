using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class girl_script : MonoBehaviour
{
    private float horizontal;
    public float speed;
    private bool facingRight = true;

    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        //float yinput = Input.GetAxis("y");
        if (xinput > 0)
        {
            body.velocity = new Vector2(speed, body.velocity.y).normalized;

        }
        else if (xinput < 0)
        {
            body.velocity = new Vector2(-speed, body.velocity.y).normalized;
        }
        else if (xinput == 0)
        {
            body.velocity = new Vector2(0,0);
        }
    }
}
