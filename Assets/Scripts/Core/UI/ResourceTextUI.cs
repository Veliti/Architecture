using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class ResourceTextUI : MonoBehaviour
{
    private TMP_Text _text;
    private Resource _resource;

    public void Init(Resource resource)
    {
        _resource = resource;
        _resource.OnResourceChange += UpdateUI;
    }

    private void UpdateUI() =>  _text.text = $"{_resource.Name}: {_resource.CurrentResource}";

    private void Awake() => _text = GetComponent<TMP_Text>();

    private void OnDisable() => _resource.OnResourceChange -= UpdateUI;
}
