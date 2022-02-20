using UnityEngine;

public class Square : Shape, ISelectable
{
    [SerializeField] Resource _resource;

    private readonly int MOVES_ADDED = 1;

    void ISelectable.InteractWith(Shape shape)
    {
        if(shape.TryGetComponent<Circle>(out var _) & shape.IsShapeActive)
        {
            if(shape.ShapeSize >= ShapeSize)
            {
                DisableShape();
                shape.DisableShape();
                transform.position = shape.transform.position;
                _resource.TryToAddResource(MOVES_ADDED);
            }
        }
    }

    private void OnValidate() => ApplySize();
}
