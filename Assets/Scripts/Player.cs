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
        /*if (Input.GetButton("Fire1") || Input.touchCount > 0)
        {
            Vector3 point = Input.mousePosition;
            point.z = 0f;
            point = cam.ScreenToWorldPoint(point);
            bal.AddForce(point * jump);
            
        }*/
        if (Input.GetButton("Fire1") || Input.touchCount > 0)
        {
            Vector3 point = Input.mousePosition;
            point.z = 0f;
            point = cam.ScreenToWorldPoint(point);
            bal.AddForce(point * jump, ForceMode2D.Impulse);
        }
       // bal.AddForce(mousePositionOnScreen * jump);
       //bal.AddRelativeForce(mousePositionOnScreen);
    }
}
