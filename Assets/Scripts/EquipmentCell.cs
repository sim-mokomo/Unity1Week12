using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentCell : MonoBehaviour,IPickupedItemCell
{
    [SerializeField] private Text _name;
    [SerializeField] private Text _attack;
    [SerializeField] private Text _defence;
    [SerializeField] private Text _durable;
    
    public void Setup(IPickupedItem pickupedItem)
    {
        var equipment = pickupedItem as Equipment;
        _name.text = equipment.Name;
        _attack.text = $"攻:{equipment.Attack}";
        _defence.text = $"防:{equipment.Defence}";
        _durable.text = $"耐久:{equipment.Durable}";
    }
}
