using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static public Inventory _inventoryPlayer;
    static public bool _pause = false;
    public GameObject inventory;
    GameObject[] menus;
    void Start()
    {
        _inventoryPlayer = inventory.GetComponent<Inventory>();
        menus = GameObject.FindGameObjectsWithTag("Inventory");
        OnOffInventory();
    }

    void OnOffInventory()
    {
        for (int i = 0; i < menus.Length; i++)
            menus[i].SetActive(_pause);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            _pause =! _pause;
            OnOffInventory();
        }
    }
}
