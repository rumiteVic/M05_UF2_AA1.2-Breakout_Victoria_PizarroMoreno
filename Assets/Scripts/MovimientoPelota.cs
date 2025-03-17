using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class MovimientoPelota : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager manager;
    public PowerUpsPlayer power;
    public float speed;
    float horizontal;
    float vertical;
    public bool iz = false;
    public bool de = false;
    public bool centro = false;
    // Start is called before the first frame update

    private void Awake()
    {
        manager = FindObjectOfType<GameManager>();
        power = FindObjectOfType<PowerUpsPlayer>();
        Spawn();
    }

    void Start()
    {
        if (manager.cantidadBolasExtra == 0)
        {
            Spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(horizontal, vertical).normalized;

        transform.position += direccion * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vertical")
        {
            horizontal *= -1;
        }
        if (collision.gameObject.tag == "Horizontal" || collision.gameObject.tag == "Player")
        {
            Vector3 dir = transform.position - collision.transform.position;
            dir.Normalize();
            horizontal = dir.x;
            vertical = dir.y;
        }
        if(collision.gameObject.tag == "detrasPlayer")
        {
            if(manager.cantidadBolasExtra > 0)
            {
                manager.vidas -= 1;
                manager.cantidadBolasExtra -= 1;
                Destroy(gameObject);
            }
            else
            {
                manager.vidas -= 1;
                Spawn();
            }
        }
    }

    void Spawn()
    {
        if (!iz && !de && !centro)
        {
            transform.position = new Vector3(0, 0, 0);
            horizontal = Random.Range(-1f, 1f);
            vertical = -1f;
        }
        if (iz)
        {
            horizontal = -0.5f;
            vertical = 1f;
            iz = false;
        }
        else if (de)
        {
            horizontal = 0.5f;
            vertical = 1f;
            de = false;
        }
        else if (centro)
        {
            horizontal = 0f;
            vertical = 1f;
            centro = false;
        }
    }

}
