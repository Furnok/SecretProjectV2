using BT.ScriptablesObject;
using Sirenix.OdinInspector;
using UnityEngine;

public abstract class VisualUpdater<T> : MonoBehaviour
{
    [Title("Reference")] 
    [SerializeField] protected RuntimeScriptableObject<T> rso;

    protected void OnEnable()
    {
        rso.OnChanged += UpdateBar;
        UpdateBar();
    }

    protected void OnDisable() => rso.OnChanged -= UpdateBar;

    protected abstract void UpdateBar();
}