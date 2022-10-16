using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Cube : Object
{
    public Cube() : base("Cube", new Color(255f, 0f, 0f))
    { }

    public override void DisplayText()
    {
        Debug.Log("Cube was clicked!");
    }
}
