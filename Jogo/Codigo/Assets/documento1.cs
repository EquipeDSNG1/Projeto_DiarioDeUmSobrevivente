using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class documento1 : MonoBehaviour
{
    public Text documento;
    public Image fundo;
    public Image maozinha;


    void Start(){
        documento.enabled = false;
        fundo.enabled = false;
        maozinha.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.tag == "Player"){
         documento.enabled = true;
         fundo.enabled = true;
         maozinha.enabled = true;
         GetComponent<AudioSource>().enabled = true;
        }
    }
    void OnTriggerExit2D(Collider2D hit){
        if(hit.tag == "Player"){
         documento.enabled = false;
         fundo.enabled = false;
         maozinha.enabled = false;
         GetComponent<AudioSource>().enabled = false;
        }
    }
}
