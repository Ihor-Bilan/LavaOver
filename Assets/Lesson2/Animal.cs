using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animal
{
    public void Eat()
    {
        Debug.Log("The animal eats");
    }

    public void Sleep()
    {
        Debug.Log("The beast sleeps");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Debug.Log("The dog barks");
    }
}

public class InheritanceExample : MonoBehaviour
{
    void Start()
    {
        Dog myDog = new Dog();
        myDog.Eat(); 
        myDog.Sleep(); 
        myDog.Bark(); 
    }
}
