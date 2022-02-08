using UnityEngine;

public class Circle : Shape
{   
    private readonly float SQRT_TWO = Mathf.Sqrt(2f);

    protected override void ApplySize()
    {
        transform.localScale = SQRT_TWO * Vector3.one * ShapeSize / BASE_SHAPE_SIZE;
    }

    private void OnValidate() => ApplySize();
}
