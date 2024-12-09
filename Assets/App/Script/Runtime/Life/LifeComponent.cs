using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class LifeComponent : MonoBehaviour, ILife
{
    [Title("Settings")]
    [SerializeField] private float maxLife;
    
    [Title("References")]
    [SerializeField] private RSO_Life rsoLife;
    [SerializeField] private UnityEvent death;

    private void Awake()
    {
        rsoLife.Value = new SLife{CurrentLife = maxLife,MaxLife = maxLife};
    }

    public void ReceiveDamage(float amount)
    {
        rsoLife.Value = new SLife{ CurrentLife = rsoLife.Value.CurrentLife - amount, MaxLife = maxLife};
        if (rsoLife.Value.CurrentLife <= 0) death.Invoke();
    }

    public void RecoverLife(float amount)
    {
    }

    private void OnDestroy() => Awake();
}