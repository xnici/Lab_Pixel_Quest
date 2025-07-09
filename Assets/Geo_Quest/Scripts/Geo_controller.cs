using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Geo_controller : MonoBehaviour
{
    string x = "Hello ";
    int var = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string y = "World";
        Debug.Log(x+y);
      
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var);
        var++;
    }
}

