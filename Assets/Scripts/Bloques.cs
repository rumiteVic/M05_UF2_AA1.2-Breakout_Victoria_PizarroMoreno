using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bloque;
    public GameManager manager;
    public int num;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "pelota")
        {
            manager.puntuacion = manager.puntuacion + num;
            Muerte();
        }
    }

    public void Muerte()
    {
        Destroy(bloque);
    }
}
