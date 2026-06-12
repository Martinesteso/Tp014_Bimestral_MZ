using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_tiempo;
    public GameObject panelWin;
    public GameObject panelGameOver;
    public GameManager GameMGR;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void UpdateTimer()
    {
        if (GameMGR.tiempoTranscurrido < 0)
        {
            GameMGR.tiempoTranscurrido = 0;
        }
        txt_tiempo.text = "TIEMPO: " + (GameMGR.tiempoTranscurrido).ToString("F2");
    }

    public void UpdateScore(int puntos)
    {
        txt_puntaje.text = "PUNTAJE: " + puntos;
    }

    public void MostrarPanelWin()
    {
        panelWin.SetActive(true);
    }

    public void MostrarPanelGameOver()
    {
        panelGameOver.SetActive(true);
    }
}
