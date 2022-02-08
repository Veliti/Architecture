using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour, InputConfig.IGameplayActions
{
    public Action<Vector2> PressScreenPosition;

    private InputConfig _inputConfig;
    private Vector2 _currentScreenPosition;

    void InputConfig.IGameplayActions.OnClick(InputAction.CallbackContext context)
    {
        if(context.canceled)
            PressScreenPosition?.Invoke(_currentScreenPosition);
    }

    void InputConfig.IGameplayActions.OnScreenPosition(InputAction.CallbackContext context)
    {
        _currentScreenPosition = context.ReadValue<Vector2>();
    }

    private void Start()
    {
        _inputConfig = new InputConfig();
        _inputConfig.Enable();
        _inputConfig.Gameplay.SetCallbacks(this);
    }
}
