using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : IPickupedItem
{
    private string _name;
    private string _description;
    private int _attack;
    private int _defence;
    private int _durable;

    public string Name => _name;
    public string Description => _description;
    public int Attack => _attack;
    public int Defence => _defence;
    public int Durable => _durable;
    
    public Equipment(string name,string description,int attack,int defence,int durable)
    {
        _name = name;
        _description = description;
        _attack = attack;
        _defence = defence;
        _durable = durable;
    }

    public Type GetCellType()
    {
        return typeof(EquipmentCell);
    }
}
