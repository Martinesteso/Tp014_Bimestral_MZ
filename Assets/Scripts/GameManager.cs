using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    UIMANAGER uiManagerScript;
    public static float tiempoTranscurrido = 60f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        uiManagerScript = GameObject.FindObjectOfType<UIMANAGER>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido -= Time.deltaTime;

        if (tiempoTranscurrido <= 0)
        {
            tiempoTranscurrido = 0;
            uiManagerScript.MostrarPanelGameOver();
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
