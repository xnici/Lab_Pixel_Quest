using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float JumpForce=10f;
    public float CapsuleHeight =0.25f;
    public float CapsuleRadius = 0.08f;
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    public float FallForce = 2;
    public string _WaterTag="Water";
    private Vector2 GravityVector;
    private Boolean _waterCheck;
    // Start is called before the first frame update
    void Start()
    {
        GravityVector = new Vector2(0, Physics2D.gravity.y);
        _rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_WaterTag)) 
        { 
         _waterCheck = true;
        
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(_WaterTag))
        {
            _waterCheck = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space)&& (_groundCheck ||_waterCheck))

        {
            _rb.velocity = new Vector2(_rb.velocity.x, JumpForce);
        
        }

        if(_rb.velocity.y < 0 && !_waterCheck) 
            
            {
            _rb.velocity += GravityVector * (FallForce * Time.deltaTime);
             }
    }
}
