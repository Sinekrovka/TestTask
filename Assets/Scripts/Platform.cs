using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private void OnTriggerEnter2D(Collider2D other)
    {
        _spriteRenderer.color = Color.white;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        _spriteRenderer.color = Color.black;
    }

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
