﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBossPreviewWarningWindow : MonoBehaviour
{
    [SerializeField] private UIBossConfigView _bossConfigView;

    public void ApplyBossConfig(BossConfig config)
    {
        _bossConfigView.Apply(config.Name,config.Description,config.Icon);
    }
}
