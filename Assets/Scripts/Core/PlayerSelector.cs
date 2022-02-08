using UnityEngine;

[RequireComponent(typeof(Input))]
public class PlayerSelector : MonoBehaviour
{
    private Input _input;
    private ISelectable _currentSelected;

    private void Click(Vector2 screenPosition)
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(screenPosition), Vector2.zero);
        if(hit)
        {
            if(_currentSelected != null)
            {
                if(hit.transform.TryGetComponent<Shape>(out var shape) & shape.IsShapeActive)
                {
                    _currentSelected.InteractWith(shape);
                }
                Deselect();
            }
            else
            {
                Deselect();
                if (hit.transform.TryGetComponent<ISelectable>(out var selectable))
                {
                    _currentSelected = selectable;
                }
            }
        }
    }
    
    private void Deselect() => _currentSelected = null;

    private void Awake() => _input = GetComponent<Input>();
    private void OnEnable() => _input.PressScreenPosition += Click;
    private void OnDisable() => _input.PressScreenPosition -= Click;
}
