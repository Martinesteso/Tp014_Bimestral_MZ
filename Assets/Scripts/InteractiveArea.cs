using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    public int contadorRecolectados = 0;
    UIMANAGER uiManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        uiManagerScript = GameObject.FindObjectOfType<UIMANAGER>();
    }


    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Coleccionable"))
        {
            Destroy(col.gameObject);
            contadorRecolectados = contadorRecolectados + 1;
            uiManagerScript.UpdateScore(contadorRecolectados);
        }

        if (contadorRecolectados >= 5)
        {
            uiManagerScript.MostrarPanelWin();
            Time.timeScale = 0;
        }
    }
}
