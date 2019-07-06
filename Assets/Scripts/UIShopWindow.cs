using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShopWindow : MonoBehaviour
{
    public event Action OnNextSequence;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            OnNextSequence?.Invoke();
    }
}
