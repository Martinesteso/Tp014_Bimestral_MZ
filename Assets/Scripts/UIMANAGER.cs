using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI Txt_puntaje;
    public TextMeshProUGUI Txt_tiempo;
    public GameManager GameMgr;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTimer(){
        updateTimer.text = GameMgr.timer;
    }
}
