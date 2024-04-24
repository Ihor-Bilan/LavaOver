using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverloadingExample : MonoBehaviour
{
        public void PrintMessage(string message)
    {
        Debug.Log(message);
    }

        public void PrintMessage(int number)
    {
        Debug.Log("Number: " + number);
    }

       public void PrintMessage(float number)
    {
        Debug.Log("Real number: " + number);
    }

    void Start()
    {
        PrintMessage("Hello, world!"); 
        PrintMessage(10); 
        PrintMessage(3.14f); 
    }
}
