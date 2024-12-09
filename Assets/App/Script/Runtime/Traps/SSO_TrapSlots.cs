using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "SSO_TrapSlots", menuName = "ScriptableObject/SSO_TrapSlots")]
public class SSO_TrapSlots : ScriptableObject
{
    [ReadOnly] public List<TrapSlot> trapSlots;
}