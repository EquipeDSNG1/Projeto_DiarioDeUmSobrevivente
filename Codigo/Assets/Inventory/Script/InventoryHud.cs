using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHud : Inventory
{
    void ItensInGame()
    {
        if (desenhaItens)
        {
            int qntItens = (Player._inventoryPlayer.itens.Count > 3) ? 3 : Player._inventoryPlayer.itens.Count;
            itens = Player._inventoryPlayer.itens.GetRange(0, qntItens);
            desenhaItem();
            desenhaItens = false;
        }
    }
    void Start()
    {
        desenhaItem();
    }

    void Update()
    {
        ItensInGame();
    }
}
