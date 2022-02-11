using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class ResourceUI : MonoBehaviour
{
    [SerializeField] ResourceSO _resource;
    [SerializeField] string _resourceText;

    private TMP_Text _text;

    public void UpdateUI(int resourceNewValue) => _text.text = _resourceText + resourceNewValue;

    private void Awake() => _text = GetComponent<TMP_Text>();

    private void OnEnable() => _resource.OnResourceChange += UpdateUI;
    private void OnDisable() => _resource.OnResourceChange -= UpdateUI;
}
