using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public int ShapeSize {get => _size; set { if(value > 0) {_size = value; ApplySize();}}}
    public bool IsShapeActive => _isShapeActive;

    [SerializeField,Range(0, 100)]int _size = BASE_SHAPE_SIZE; // 10 is default Square is base Shape

    private bool _isShapeActive = true;

    protected static readonly int BASE_SHAPE_SIZE = 10;

    public virtual void EnableShape() => _isShapeActive = true;
    public virtual void DisableShape() => _isShapeActive = false;

    protected virtual void ApplySize()
    {
        transform.localScale = Vector3.one * ShapeSize / BASE_SHAPE_SIZE;
    }
}
