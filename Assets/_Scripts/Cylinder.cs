using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Cylinder : Object
{
    public Cylinder() : base("Cylinder", new Color(0f, 255f, 0f))
    { }

    public override void DisplayText()
    {
        Debug.Log("Cylinder was clicked!");
    }
}
