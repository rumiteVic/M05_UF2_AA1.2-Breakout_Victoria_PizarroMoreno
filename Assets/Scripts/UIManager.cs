using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameManager manager;
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vidas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacion.text = manager.puntuacion.ToString();
        vidas.text = manager.vidas.ToString();
        if(manager.vidas <= 0)
        {
            Debug.Log("Fin");
        }
    }
}
