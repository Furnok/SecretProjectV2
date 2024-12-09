using Sirenix.OdinInspector;
using UnityEngine;
public class CameraFollower : MonoBehaviour
{
    [Title("Settings")] 
    [SerializeField] private Vector3 offsetTarget;
    [SerializeField] private float smoothTime;

    [Title("References")]
    [SerializeField] private RSO_TargetTransform rsoTarget;

    private Vector3 _velocity;
    
    private void Update()
    {
        if (!rsoTarget.Value) return;
        transform.position = Vector3.SmoothDamp(transform.position ,rsoTarget.Value.position + offsetTarget, ref _velocity, smoothTime);
    }
    
}