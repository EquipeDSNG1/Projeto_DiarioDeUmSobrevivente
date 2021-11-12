using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sair : MonoBehaviour
{
    public Button botao2;

    void Start(){
        botao2.onClick = new Button.ButtonClickedEvent();
        botao2.onClick.AddListener(() => BotaoS());
    }

    void BotaoS()
    { 
        Application.Quit();
    }
}
