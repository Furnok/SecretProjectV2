using Sirenix.OdinInspector;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [Title("Settings")]
    [SerializeField] private string tagTarget = "Player";
    [SerializeField][MinValue(0)] private float damage;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(tagTarget)) return;
        if (other.attachedRigidbody.TryGetComponent(out ILife lifeComponent))
        {
            lifeComponent.ReceiveDamage(damage);
        }
    }
}