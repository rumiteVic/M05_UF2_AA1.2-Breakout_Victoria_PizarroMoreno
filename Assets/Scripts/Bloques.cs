using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Bloques : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bloque;
    public GameManager manager;
    public int num;

    public GameObject powerUpRojo;
    public GameObject powerUpVerde;
    public GameObject powerUpAzul;

    int random = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        random = Random.Range(0,10);
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
        if(random == 0)
        {
            GameObject powerRojo = Instantiate(powerUpRojo, transform.position, transform.rotation);
        }
        else if (random == 1)
        {
            GameObject powerVerde = Instantiate(powerUpVerde, transform.position, transform.rotation);
        }
        else if (random == 2)
        {
            GameObject powerAzul = Instantiate(powerUpAzul, transform.position, transform.rotation);
        }
        else
        {

        }
        Destroy(bloque);
    }
}
