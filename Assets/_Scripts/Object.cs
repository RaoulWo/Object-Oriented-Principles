using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Object : MonoBehaviour
{
    public string Name { get; private set; }
    public Color Color { get; private set; }

    protected string _name;
    protected Color _color;

    protected Object(string name, Color color)
    {
        _name = name;
        _color = color;
    }

    private void Start()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.color = _color;
    }

    public abstract void DisplayText();
}
