using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : IPickupedItem
{
    private string _name;
    private string _description;

    public string Name => _name;
    public string Description => _description;

    public Item(string name,string description)
    {
        _name = name;
        _description = description;
    }
    
    private void Use()
    {
        
    }

    public Type GetCellType()
    {
        return typeof(ItemCell);
    }
}
