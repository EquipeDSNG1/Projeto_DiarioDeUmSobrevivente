using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public RectTransform content;
    public List <GameObject> itens;
    public int index1 =-1, index2 =1;

    public void AddItem(GameObject item)
    {
        itens.Add(item);
        item.GetComponent<Item>().index = itens.Count-1;
        desenhaItem();
    }

    public void TrocaItem(int index)
    {
        if(index1 == -1)
        {
            index1 = index;
        }
        else
        {
            index2 = index;
            GameObject aux_ = itens[index1];
            itens[index1] = itens[index2];
            itens[index2] = aux_;

            itens[index1].GetComponent<Item>().index = index1;
            itens[index2].GetComponent<Item>().index = index2;

            index1 =-1;
            index2 =-2;
            desenhaItem();
        }
    }

    void desenhaItem()
    {
    while(content.childCount>0)
    {
        Transform filho = content.GetChild(0);
        filho.SetParent(null);
        Destroy(filho.gameObject);
    }

    for (int i =0; i<itens.Count; i++)
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
