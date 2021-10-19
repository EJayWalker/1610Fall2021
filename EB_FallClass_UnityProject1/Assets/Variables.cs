using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int myNum = 50;
    string myName = "John";
    int x = 5;
    int y = 10;
    int z = x + y;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Console.WriteLine(x + y);
        Console.WriteLine(z);
    }
}
