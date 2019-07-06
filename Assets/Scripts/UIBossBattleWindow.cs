using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBossBattleWindow : MonoBehaviour
{
    [SerializeField] private PickupedCellScrollView _pickupedCellScrollView;

    private void OnEnable()
    {
        var player = FindObjectOfType<Player>();
        player.PickupedItems.ForEach(p =>
        {
            
            var cell = PickupedItemCellFactory.Instance.CreateCell(p, Vector3.zero, Quaternion.identity,Vector3.one);
            _pickupedCellScrollView.Add(cell);
        });
    }
}
