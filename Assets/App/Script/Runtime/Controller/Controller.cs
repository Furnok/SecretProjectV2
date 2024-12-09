using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class Controller : MonoBehaviour
{
    [Title("References")] 
    [SerializeField] private UnityEvent<Vector2> moveInputTrigger;
    
    private InputActionsController _inputActionController;

    public void Awake()
    {
        _inputActionController = new InputActionsController();
        _inputActionController.Controller.Move.Enable();
        _inputActionController.Enable();
    }

    private void Update()
    {
        if (_inputActionController.Controller.Move.IsPressed())
        {
            moveInputTrigger?.Invoke(_inputActionController.Controller.Move.ReadValue<Vector2>());
        }
    }
    
}