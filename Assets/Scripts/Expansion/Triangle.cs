using UnityEngine;

public class Triangle : Shape, ISelectable
{
    [SerializeField] int _sizeDelta = -1;

    void ISelectable.InteractWith(Shape shape)
    {
        if(shape.TryGetComponent<Square>(out var square))
        {
            if(EnergyResource.ResourceInstance.TryToUseResource())
            {
                square.ShapeSize += _sizeDelta;
                Destroy(gameObject);
            }
        }
    }

    private void OnValidate() => ApplySize();
}
