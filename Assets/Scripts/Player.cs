using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D bal;
    public PlanetSettings gravitySetting;
    
    void Start()
    {
        bal = GetComponent<Rigidbody2D>();
        bal.gravityScale = gravitySetting.Gravity;
        
        Debug.Log(bal.gravityScale);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
