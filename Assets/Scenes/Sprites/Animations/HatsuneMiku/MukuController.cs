using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MukuController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private AudioSource _audioSource;
    
    public AudioClip rainbowRoad;
    
    
    
    public float jumpForce = 1;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CommandHandler.JUMP_MIKU)
            _animator.Play("jump");
        if (CommandHandler.RAINBOW_ROAD_MIKU)
        {
            _audioSource.clip = rainbowRoad;
            _audioSource.Play();
            _animator.Play("rainbow");
        }
        if(CommandHandler.ROLL_FAIL_MIKU)
            _animator.Play("roll");
        if(CommandHandler.DASH_MIKU)
            _animator.Play("dash");
        
        if(CommandHandler.DANCE_MIKU)
            _animator.Play("dancing");
        
        if (CommandHandler.STOP)
        {
            _audioSource.Stop();
            _animator.Play("Idle");
        }
    }

    public void Jump()
    {
        _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    public void OnMouseDown()
    {
        _audioSource.Stop();
        _animator.Play("Idle");

    }
}
