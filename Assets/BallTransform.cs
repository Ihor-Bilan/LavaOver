using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    private int framesElapsed = 0;
    private int maxFrames = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (framesElapsed < maxFrames)
        {
            transform.localScale += scaleChange;
            framesElapsed++;
        }
    }
}
