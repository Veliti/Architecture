using UnityEngine;

public class Triangle : Shape, ISelectable
{
    [SerializeField] ResourceSO _resource;
    [SerializeField] int _sizeDelta = -1;
    [SerializeField] int _energyConsumedOnUse = 1;

    void ISelectable.InteractWith(Shape shape)
    {
        if(shape.TryGetComponent<Square>(out var square))
        {
            if(_resource.TryToUseResource(-_energyConsumedOnUse))
            {
                square.ShapeSize += _sizeDelta;
                Destroy(gameObject);
            }
        }
    }
    
    private void OnValidate() => ApplySize();
}
