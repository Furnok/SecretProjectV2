using System;
using UnityEngine;

[Serializable]
public struct SLife
{
    public int MaxLife { get; set; }
    private int _currentLife;
    public int CurrentLife
    {
        get => _currentLife;
        set => _currentLife = Mathf.Max(value, 0);
    }
}