using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickButton : MonoBehaviour
{
    public float gravity;
    public Color colorSky;
    public PlanetSettings planetData;

    public void SetData()
    {
        planetData.Gravity = gravity;
        planetData.SkyColor = colorSky;
        SceneManager.LoadScene("PlanetSimulation");
    }

}
