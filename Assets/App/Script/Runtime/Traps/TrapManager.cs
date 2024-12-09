using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

public class TrapManager : MonoBehaviour
{
    [Title("Settings")] 
    [SerializeField] private int trapCountGenerated;
    [SerializeField] private Vector3 offsetSpawn;
    
    [Title("References")]
    [SerializeField] private GameObject trapPrefab;
    [SerializeField] private SSO_TrapSlots ssoTrapSlots;
    
    private List<TrapSlot> _trapsSlot = new List<TrapSlot>();

    private void Start()
    {
        RegenerateTraps();
    }
    
    private void RegenerateTraps()
    {
        var trapsSlotCopy = new List<TrapSlot>(ssoTrapSlots.trapSlots);
        trapsSlotCopy.FindAll(o => o is { alwaysSpawn: true }).ForEach(SpawnTrap);
        trapsSlotCopy = trapsSlotCopy.FindAll(o => o is { alwaysSpawn: false });
        for (int i = 0; i < trapCountGenerated; ++i)
        {
            if (trapsSlotCopy.Count == 0) break;
            var trapSlot = trapsSlotCopy.GetRandom();
            SpawnTrap(trapSlot);
            trapsSlotCopy.Remove(trapSlot);
        }
    }
    
    private void SpawnTrap(TrapSlot trapSlot)
    {
        var trapGenerated = Instantiate(trapPrefab, trapSlot.position + offsetSpawn, Quaternion.identity, transform).GetComponent<Trap>();
    }
}