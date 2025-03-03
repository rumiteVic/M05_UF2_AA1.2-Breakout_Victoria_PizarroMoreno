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
        }
        else if (verde)
        {
            Vector3 direction = new Vector2(3, 0);
            GameObject pelotaTmp = Instantiate(pelota, transform.position + direction, transform.rotation);
            GameObject pelotaTmp1 = Instantiate(pelota, transform.position, transform.rotation);
            Vector3 direction1 = new Vector2(-3, 0);
            GameObject pelotaTmp2 = Instantiate(pelota, transform.position + direction1, transform.rotation);
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
