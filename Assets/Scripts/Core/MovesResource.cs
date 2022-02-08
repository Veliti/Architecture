public class MovesResource : Resource<MovesResource>
{
    public FloatUnityEvent OnResourceChange;
    public int CurrentMoves {get => _currentMoves; private set{_currentMoves = value; OnResourceChange?.Invoke(CurrentMoves);}}

    private int _currentMoves;

    public override bool TryToUseResource()
    {
        CurrentMoves++;
        return true;
    }

    private void Start() => CurrentMoves = 0;
}
