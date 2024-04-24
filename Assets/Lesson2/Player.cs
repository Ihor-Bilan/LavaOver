using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private int health;
 
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
           
            if (value >= 0)
            {
                health = value;
            }
            else
            {
                Debug.LogWarning("Health cannot be negative!");
            }
        }
    }

    void Start()
    {
        
        Health = 100; 
        Debug.Log("The player's initial health: " + Health);
    }
}
