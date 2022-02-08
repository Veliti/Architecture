using UnityEngine;

public class EnergyResource : Resource<EnergyResource>
{
    public FloatUnityEvent OnResourceChange;
    public int CurrentEnergy {get => _currentEnergy; private set{_currentEnergy = value; OnResourceChange?.Invoke(CurrentEnergy);}}

    [SerializeField] int _startingEnergy = 3;

    private int _currentEnergy;

    public override bool TryToUseResource()
    {
        if(_currentEnergy <= 0) return false;

        CurrentEnergy--;
        return true;
    }

    private void Start() => CurrentEnergy = _startingEnergy;
}
