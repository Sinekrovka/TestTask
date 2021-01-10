using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetCamera : MonoBehaviour
{
    public PlanetSettings settingSky;
    private Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.backgroundColor = settingSky.SkyColor;
    }
}
