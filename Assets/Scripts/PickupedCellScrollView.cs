using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupedCellScrollView : MonoBehaviour
{
    [SerializeField] private GameObject _contentRoot;

    public void Add(GameObject cell)
    {
        cell.transform.SetParent(_contentRoot.transform);
        cell.transform.localScale = Vector3.one;
        var pos = cell.transform.localPosition;
        pos.z = 0.0f;
        cell.transform.localPosition = pos;
    }
}
