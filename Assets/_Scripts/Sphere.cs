using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Sphere : Object
{
    public Sphere() : base("Sphere", new Color(0f, 0f, 255f))
    { }

    public override void DisplayText()
    {
        Debug.Log("Sphere was clicked!");
    }
}
