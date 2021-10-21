using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour

{

    public float propSpeed;
    private Vector3 propRotate = new Vector3(0, 0, 5);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Propeller spins around z-axis
        transform.Rotate(propSpeed * propRotate);
    }
}
