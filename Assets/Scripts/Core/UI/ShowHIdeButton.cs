using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ShowHIdeButton : MonoBehaviour
{
    [SerializeField] GameObject _targetElement;

    private Button _button;

    private void ShowHide() => _targetElement.SetActive(!_targetElement.activeSelf);

    private void Awake() => _button = GetComponent<Button>();

    private void Start() => _button.onClick.AddListener(ShowHide);
}
