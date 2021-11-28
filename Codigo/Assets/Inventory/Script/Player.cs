using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static public Inventory _inventoryPlayer;
    public GameObject inventory;
    void Start()
    {
        _inventoryPlayer = inventory.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
