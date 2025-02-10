using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float horizontal;
    public float speed;

    // Update is called once per frame
    void Update()
    {
 

        horizontal = Input.GetAxis("Horizontal");

        Vector3 direccion = new Vector3(horizontal, 0);

        transform.position += direccion * speed * Time.deltaTime;
    }
}
