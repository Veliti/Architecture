using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class ResourceUI : MonoBehaviour
{
    [SerializeField] string _resourceText;

    private TMP_Text _text;

    public void UpdateUI(float resourceNewValue) => _text.text = _resourceText + resourceNewValue;

    private void Awake() => _text = GetComponent<TMP_Text>();
}
