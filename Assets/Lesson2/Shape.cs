using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shape : MonoBehaviour
{
    public virtual void Draw()
    {
        Debug.Log("Drawing a shape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Debug.Log("Drawing a circle");
    }
}

public class Square : Shape
{
    public override void Draw()
    {
        Debug.Log("Drawing a square");
    }
}

public class PolymorphismExample : MonoBehaviour
{
    void Start()
    {
        Shape[] shapes = new Shape[2];
        shapes[0] = new Circle();
        shapes[1] = new Square();

        foreach (Shape shape in shapes)
        {
            shape.Draw(); // Поліморфний виклик методу Draw()
        }
    }
}
