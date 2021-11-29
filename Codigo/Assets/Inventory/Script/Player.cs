using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static public Inventory _inventoryPlayer;
    static public bool _pause;
    public GameObject inventory;
    GameObject[] menus;
    GameObject[] shop;
    void Start()
    {
        _inventoryPlayer = inventory.GetComponent<Inventory>();
        menus = GameObject.FindGameObjectsWithTag("Inventory");
        shop = GameObject.FindGameObjectsWithTag("Shop");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            _pause =! _pause;
            
            for (int i = 0; i < menus.Length; i++)
                menus[i].SetActive(_pause);
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            _pause =! _pause;
            
            for (int i = 0; i < shop.Length; i++)
                shop[i].SetActive(_pause);
        }
    }
}
