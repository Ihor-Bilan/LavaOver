using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGenericClass<T>
{
    private T myGenericField;

    public MyGenericClass(T value)
    {
        myGenericField = value;
    }

       public T GetValue()
    {
        return myGenericField;
    }
}

public class GenericExample : MonoBehaviour
{
    void Start()
    {
        MyGenericClass<int> intGenericObject = new MyGenericClass<int>(10);
        Debug.Log("Meaning intGenericObject: " + intGenericObject.GetValue());

        MyGenericClass<string> stringGenericObject = new MyGenericClass<string>("Hello, World!");
        Debug.Log("Meaning stringGenericObject: " + stringGenericObject.GetValue());
    }
}
