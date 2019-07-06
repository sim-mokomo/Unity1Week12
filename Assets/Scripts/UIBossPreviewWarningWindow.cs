using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBossPreviewWarningWindow : MonoBehaviour
{
    [SerializeField] private UIBossConfigView _bossConfigView;

    private void Start()
    {
        _bossConfigView.Apply("test","test",null);
    }
}
