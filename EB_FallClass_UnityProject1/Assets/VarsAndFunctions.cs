using System.Collections;
using UnityEngine;

public class VarsAndFunctions : MonoBehaviour
{
    int myInt = 5;


    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.log(myInt);
    }


    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
