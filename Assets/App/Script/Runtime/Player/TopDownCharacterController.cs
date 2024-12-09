using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

public class TopDownCharacterController : MonoBehaviour
{
    [Title("Settings")]
    [SerializeField] private float movementSpeed = 2.0f;

    [Title("Reference")] 
    [SerializeField] private RSO_TargetTransform rsoPlayerTransform;
    [SerializeField] private Rigidbody rb;

    [Title("Output")]
    [SerializeField] private RSE_GameOver rsoGameOver;
    
    public void Awake()
    {
        rsoPlayerTransform.Value = transform;
    }

    public void Move(Vector2 direction)
    {
        Vector3 movement = new Vector3(direction.x, 0, direction.y) * movementSpeed;
        rb.AddForce(movement);
    }

    public void OnDeath()
    {
        rsoGameOver.Call();
        Destroy(gameObject);
    }
}
