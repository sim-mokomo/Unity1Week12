using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class PickupedItemCellFactory : MonoBehaviour
{
    private static PickupedItemCellFactory _instance;

    public static PickupedItemCellFactory Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<PickupedItemCellFactory>();
            return _instance;
        }
    }

    [System.Serializable]
    private class CellTypeData
    {
        [SerializeField] private string _className;
        [SerializeField] private GameObject _prefab;
        public string ClassName => _className;
        public GameObject Prefab => _prefab;
    }

    [SerializeField] private List<CellTypeData> cellTypes = new List<CellTypeData>();
    
    public GameObject CreateCell(IPickupedItem item,Vector3 pos,Quaternion rot,Vector3 scale)
    {
        var cellType = item.GetCellType();
        var cellTypeData = cellTypes.FirstOrDefault(d => Type.GetType(d.ClassName) == cellType);
        var cellObj = Instantiate(cellTypeData.Prefab, pos, rot);
        cellObj.transform.localScale = scale;
        cellObj.GetComponent<IPickupedItemCell>().Setup(item);
        return cellObj;
    }
}
