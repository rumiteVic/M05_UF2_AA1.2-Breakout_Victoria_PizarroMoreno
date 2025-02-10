using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteMovimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float xMax = 0;
    public float xMin = 0;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, transform.position.y);
        }
        if (transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, transform.position.y);
        }
    }
}
