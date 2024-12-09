using System;
using UnityEngine;

[Serializable]
public struct SLife
{
    public float MaxLife { get; set; }
    private float _currentLife;
    public float CurrentLife
    {
        get => _currentLife;
        set => _currentLife = Mathf.Max(value, 0f);
    }
    
    
}