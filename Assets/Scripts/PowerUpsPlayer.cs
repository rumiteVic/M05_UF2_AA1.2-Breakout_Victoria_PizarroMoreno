using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsPlayer : MonoBehaviour
{
    public bool rojo = false;
    public bool azul = false;
    public bool verde = false;
    public GameObject pelota;
    public GameManager manager;
    public GameObject pelotaiz;
    public GameObject pelotade;
    public GameObject pelotacentro;
    int cantidadAdded = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rojo)
        {
            GameObject pelotaTmp = Instantiate(pelota);
            manager.cantidadBolasExtra += 1;
            manager.vidas += 1;
            rojo = false;
        }
        else if(verde)
        {
            Vector2 directionIz = new Vector2(transform.position.x -2, transform.position.y +0.5f);
            GameObject pelotaiztmp = Instantiate(pelotaiz, directionIz, transform.rotation);

            Vector2 directionDe = new Vector2(transform.position.x + 2, transform.position.y +0.5f);
            GameObject pelotadetmp = Instantiate(pelotade, directionDe, transform.rotation);

            Vector2 directionCentro = new Vector2(transform.position.x, transform.position.y +0.5f);
            GameObject pelotacentrotmp = Instantiate(pelotacentro, directionCentro, transform.rotation);
            manager.cantidadBolasExtra += 3;
            manager.vidas += 3;
            verde = false;
        }
        else if (azul)
        {
            for(int i = 0; i < manager.vidas; i++)
            {
                GameObject extra = Instantiate(pelota);
                cantidadAdded++;
            }
            manager.cantidadBolasExtra += cantidadAdded;
            manager.vidas += cantidadAdded;
            cantidadAdded = 0;
            azul = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rojo")
        {
           rojo = true;
           azul = false;
           verde = false;
        }
        else if (collision.gameObject.tag == "azul")
        {
            rojo = false;
            azul = true;
            verde = false;
        }
        else if (collision.gameObject.tag == "verde")
        {
            rojo = false;
            azul = false;
            verde = true;
        }
    }
}
