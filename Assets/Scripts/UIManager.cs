using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameManager manager;
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vidas;
    public GameObject playy;
    public GameObject vidasplayer;
    public GameObject punt;
    public GameObject restartbutton;
    public bool restart = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
        playy.SetActive(true);
        vidasplayer.SetActive(false);
        punt.SetActive(false);
        restartbutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        puntuacion.text = manager.puntuacion.ToString();
        vidas.text = manager.vidas.ToString();
        if(manager.vidas <= 0 || manager.bloquesTotales == 0)
        {
            Time.timeScale = 0.0f;
            restartbutton.SetActive(true);
            playy.SetActive(false);
            vidasplayer.SetActive(false);
            punt.SetActive(false);

        }
    }

    public void Play()
    {
        playy.SetActive(false);
        vidasplayer.SetActive(true);
        punt.SetActive(true);
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
