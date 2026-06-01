using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    public int contadorRecolectados = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Coleccionable"))
        {
            contadorRecolectados++;
            Destroy(col.gameObject);
            Debug.Log("Objetos recolectados: " + contadorRecolectados);
        }
    }
}
