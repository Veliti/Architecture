public class Square : Shape, ISelectable
{
    void ISelectable.InteractWith(Shape shape)
    {
        if(shape.TryGetComponent<Circle>(out var _) & shape.IsShapeActive)
        {
            if(shape.ShapeSize >= ShapeSize)
            {
                DisableShape();
                shape.DisableShape();
                transform.position = shape.transform.position;
                MovesResource.ResourceInstance.TryToUseResource();
            }
        }
    }

    private void OnValidate() => ApplySize();
}
