using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBossConfigView : MonoBehaviour
{
    [SerializeField] private Text _bossNameUi;
    [SerializeField] private Text _descriptionUi;
    [SerializeField] private Image _bossIconUi;

    public void Apply(string name, string description, Sprite img)
    {
        _bossNameUi.text = name.ToUpper();
        _descriptionUi.text = description;
        _bossIconUi.sprite = img;
    }
}
