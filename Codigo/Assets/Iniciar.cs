using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{
    public string level;
    public Button botao1;

    void Start(){
        botao1.onClick = new Button.ButtonClickedEvent();
        botao1.onClick.AddListener(() => BotaoI());
    }

    void BotaoI()
    { 
        SceneManager.LoadScene(level);
    }
}
