using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StringExtensions
{
    public static int Length(this string str)
    {
        return str.Length;
    }

    public static string Reverse(this string str)
    {
        char[] charArray = str.ToCharArray();
        System.Array.Reverse(charArray);
        return new string(charArray);
    }
}

public class ExtensionMethodExample : MonoBehaviour
{
    void Start()
    {
        string myString = "Hello, World!";

        int length = myString.Length();
        Debug.Log("String length: " + length);

        string reversedString = myString.Reverse();
        Debug.Log("Inverted string: " + reversedString);
    }
}
