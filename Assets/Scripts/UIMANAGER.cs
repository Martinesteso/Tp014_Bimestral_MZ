using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI Txt_puntaje;
    public TextMeshProUGUI Txt_tiempo;
    
    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void UpdateTimer()
    {
        if (GameManager.tiempoTranscurrido < 0)
        {
            GameManager.tiempoTranscurrido = 0;
        }
        Txt_tiempo.text = "TIEMPO: " + (GameManager.tiempoTranscurrido).ToString("F2");
    }

    public void UpdateScore(int puntos)
    {
        Txt_puntaje.text = "Puntaje: " + puntos;
    }
}
