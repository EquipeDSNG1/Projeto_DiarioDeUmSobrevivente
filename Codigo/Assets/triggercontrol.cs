using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggercontrol : MonoBehaviour
{
    public string level;
    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.tag == "Player"){
            SceneManager.LoadScene(level);
        }
    }
}
