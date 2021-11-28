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

    void TrocaItem ()
    {
        Player._inventoryPlayer.TrocaItem(index);
    }

    void Start()
    {
        Button aux_ = GetComponent<Button>();
        aux_.onClick.AddListener(TrocaItem);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
