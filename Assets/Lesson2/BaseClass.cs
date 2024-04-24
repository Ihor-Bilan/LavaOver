using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseClass
{
       public virtual void PrintMessage()
       {
        Debug.Log("This is a message from the base class");
       }
}

public class DerivedClass : BaseClass
{
      public override void PrintMessage()
      {
       Debug.Log("This is an overridden message from the derived class");
      }
}

public class OverrideExample : MonoBehaviour
{
    void Start()
    {
     DerivedClass derivedObj = new DerivedClass();
     derivedObj.PrintMessage();
    }
}
