using Sirenix.OdinInspector;
using UnityEngine;
public class TriggerWin : MonoBehaviour
{
    [Title("Settings")]
    [SerializeField] private string tagTrigger;
    
    [Title("Output")]
    [SerializeField] private RSE_Win rseWin;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagTrigger)) rseWin.Call();
    }
}