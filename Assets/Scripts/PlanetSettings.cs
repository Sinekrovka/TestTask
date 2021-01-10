using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlanetB", menuName = "Planet Data", order = 51)]
public class PlanetSettings : ScriptableObject
{
    [SerializeField] private float gravity;
    [SerializeField] private Color skyColor;

    public float Gravity
    {
        get => gravity;
        set => gravity = value;
    }

    public Color SkyColor
    {
        get => skyColor;
        set => skyColor = value;
    }
}
