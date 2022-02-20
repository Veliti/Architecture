using UnityEngine;

public class ResourceUI : MonoBehaviour
{
    [SerializeField] ResourceManeger _resources;
    [SerializeField] ResourceTextUI _resourceText;

    private void Start()
    {
        foreach (var resource in _resources.ResourcesOnLevel)
        {
            var text = Instantiate<ResourceTextUI>(_resourceText, transform);
            text.Init(resource.Resource);
        }
    }
}
