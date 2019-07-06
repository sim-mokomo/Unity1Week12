﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BossConfig : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField]private string _description;
    [SerializeField]private Sprite _icon;
    
    public string Name => _name;
    public string Description => _description;
    public Sprite Icon => _icon;
}
