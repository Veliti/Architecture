using System;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Basic Resource")]
public class Resource : ScriptableObject
{
    public Action OnResourceChange;
    public int CurrentResource {get => _currentResource; private set{_currentResource = value; OnResourceChange?.Invoke();}}
    public string Name => _resourceName;

    [SerializeField] string _resourceName;

    private int _currentResource;

    public virtual bool TryToAddResource(int value)
    {
        CurrentResource += value;
        return true;
    }
    
    public virtual bool TryToRemoveResource(int value)
    {
        if(value > CurrentResource) return false;

        CurrentResource -= value;
        return true;
    }

    //Called on scene/Level change
    public virtual void ResetResource() => CurrentResource = 0;

    private void OnEnable() => CurrentResource = 0;
}
