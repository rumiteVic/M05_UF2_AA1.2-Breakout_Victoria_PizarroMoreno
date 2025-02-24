using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager manager;
    public float speed;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
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
            manager.vidas -= 1;
            Spawn();
        }
    }

    void Spawn()
    {
        transform.position = new Vector3(0, 0, 0);
        horizontal = Random.Range(-1f, 1f);
        if (horizontal < 0)
        {
            horizontal = -1;
        }
        else
        {
            horizontal = 1;
        }
        vertical = -1f;
    }
}
