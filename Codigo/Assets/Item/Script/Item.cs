using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int id, index;
    public string Name;
    public Texture2D image;
    public GameObject Objeto;
    public float Price;
    public int Qnt_max, Qnt_atual;
    public bool Destruivel;

    void Start()
    {
    }
    void Update()
    {
        
    }
}