using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public RectTransform content;
    public List <GameObject> itens;
    public int index1 =-1, index2 =1;
    public static bool _desenhaItens;

    public void AddItem(GameObject item)
    {
        itens.Add(item);
        item.GetComponent<Item>().index = itens.Count-1;
        desenhaItem();
    }

    protected void desenhaItem()
    {
        _desenhaItens = true;
        while(content.childCount>0)
        {
            Transform filho = content.GetChild(0);
            filho.SetParent(null);
            Destroy(filho.gameObject);
        }

        for (int i = 0; i < itens.Count; i++)
            {
                GameObject item = Instantiate(itens[i], content.position, Quaternion.identity) as GameObject;
                item.transform.SetParent(content.transform);
            }
    }


    void Start()
    {
        desenhaItem();
    }
    void Update()
    {
    
    }
}
