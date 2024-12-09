using System;
using Sirenix.OdinInspector;
using UnityEngine;


[ExecuteInEditMode]
public class EditorTrapSlot : MonoBehaviour
{
    [Title("References")]
    [SerializeField] private TrapSlot trapSlot;
    [SerializeField] private SSO_TrapSlots ssoTrapSlots;

    private void OnValidate()
    {
        trapSlot.position = transform.position;
        if (ssoTrapSlots == null) return;
        if (!ssoTrapSlots.trapSlots.Contains(trapSlot)) ssoTrapSlots.trapSlots.Add(trapSlot);
    }

    private void Awake()
    {
        trapSlot ??= new TrapSlot();
        OnValidate();
    }

    public void OnDestroy()
    {
        if (ssoTrapSlots.trapSlots.Contains(trapSlot)) ssoTrapSlots.trapSlots.Remove(trapSlot);
    }
}

[Serializable]
public class TrapSlot
{
    [ReadOnly] public Vector3 position;
    public bool alwaysSpawn;
}