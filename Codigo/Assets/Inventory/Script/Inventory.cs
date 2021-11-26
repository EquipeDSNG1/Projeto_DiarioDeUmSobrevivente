using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public RectTransform content;
    public List <GameObject> itens;

    public void AddItem(GameObject item)
    {
        itens.Add(item);
    }
    void desenhaItem()
    {
        if(content.childCount < itens.Count)
        {
            GameObject item = Instantiate(itens[content.childCount], content.position, Quaternion.identity) as GameObject;
            item.transform.SetParent(content.transform);
        }
    }

    void Start()
    {
        
    }
    void Update()
    {
        desenhaItem();
    }
}
