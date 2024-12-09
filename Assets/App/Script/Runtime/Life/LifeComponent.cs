using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class LifeComponent : MonoBehaviour, ILife
{
    [Title("Settings")]
    [SerializeField] private int maxLife;
    
    [Title("References")]
    [SerializeField] private RSO_Life rsoLife;
    [SerializeField] private UnityEvent death;

    private void Awake()
    {
        rsoLife.Value = new SLife{CurrentLife = maxLife,MaxLife = maxLife};
    }

    public void ReceiveDamage(int amount)
    {
        rsoLife.Value = new SLife{ CurrentLife = rsoLife.Value.CurrentLife - amount, MaxLife = maxLife};
        if (rsoLife.Value.CurrentLife <= 0) death.Invoke();
    }

    public void RecoverLife(int amount)
    {
    }

    public void ResetLife()
    {
        rsoLife.Value = new SLife{ CurrentLife = maxLife, MaxLife = maxLife};
    }

    private void OnDestroy() => Awake();
}