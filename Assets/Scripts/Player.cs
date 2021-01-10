using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlanetSettings gravitySetting;
    public float jump;
    public Camera cam;

    private Rigidbody2D bal;

    void Start()
    {
        bal = GetComponent<Rigidbody2D>();
        bal.gravityScale = gravitySetting.Gravity;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
       // bal.AddForce(mousePositionOnScreen * jump);
       //bal.AddRelativeForce(mousePositionOnScreen);
    }
}
