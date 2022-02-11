using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "ScriptableObjects/Basic Resource")]
public class ResourceSO : ScriptableObject
{
    public Action<int> OnResourceChange;
    public int CurrentResource {get => _currentResource; private set{_currentResource = value; OnResourceChange?.Invoke(CurrentResource);}}

    [SerializeField] int _staringResource;

    private int _currentResource;

    public virtual bool TryToUseResource(int deltaResource)
    {
        if (CurrentResource + deltaResource < 0)
            return false;
        
        CurrentResource += deltaResource;
        return true;
    }
    
    private void ResetResource(Scene _, Scene _2) => CurrentResource = _staringResource;

    private void OnEnable() => SceneManager.activeSceneChanged += ResetResource;
    private void OnDisable() => SceneManager.activeSceneChanged -= ResetResource;
}
