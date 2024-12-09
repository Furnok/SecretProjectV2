using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class ReceiverScriptableEvent : MonoBehaviour
{
    [Title("References")] 
    [SerializeField] private UnityEvent rseEventDiffuse;

    [Title("Input")] 
    [SerializeField] private BT.ScriptablesObject.RuntimeScriptableEvent rse;
    
    private void OnEnable() => rse.action += rseEventDiffuse.Invoke;

    private void OnDisable() => rse.action -= rseEventDiffuse.Invoke;
}