using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCell : MonoBehaviour,IPickupedItemCell
{
    [SerializeField] private Text _name;
    [SerializeField] private Text _description;

    public void Setup(IPickupedItem pickupedItem)
    {
        var item = pickupedItem as Item;
        _name.text = item.Name;
        _description.text = item.Description;
    }
}
