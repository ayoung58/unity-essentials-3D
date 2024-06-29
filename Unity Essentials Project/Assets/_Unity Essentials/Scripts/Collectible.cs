using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // public makes it editable in the inspector, private will not
    public float rotationSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // rotates half a degree in each frame by default (can be changed though)
        // we need the f if it's a decimal number bc C# defines them as floats
        transform.Rotate(0,rotationSpeed,0);
    }
}
