using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUser : MonoBehaviour
{
    void Start()
    {
        HidePlayer();
    }

    void HidePlayer()
    {
        
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.SetActive(false);
            Debug.Log("Player is hidden.");
        }
        else
        {
            Debug.LogWarning("Player not found!");
        }
    }
}
