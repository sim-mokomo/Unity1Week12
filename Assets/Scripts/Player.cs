using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<IPickupedItem> PickupedItems { get; } = new List<IPickupedItem>();

    private void Awake()
    {
        PickupedItems.Add( new Item("test1","testssssss"));
        PickupedItems.Add( new Equipment("buki1","bukinii",1,1,1));
        PickupedItems.Add( new Equipment("buki1","bukinii",1,1,1));
        PickupedItems.Add( new Equipment("buki1","bukinii",1,1,1));
        PickupedItems.Add( new Item("test2","tesssss"));
        PickupedItems.Add( new Item("test3","tessss"));
        PickupedItems.Add( new Item("test4","tessss"));
        PickupedItems.Add( new Item("test5","testssssss"));
        PickupedItems.Add( new Item("test6","ttssssss"));
    }
}
