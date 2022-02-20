using UnityEngine;

public class ResourceManeger : MonoBehaviour
{
    public ResourceSettings[] ResourcesOnLevel;

    private void Start()
    {
        foreach (var resource in ResourcesOnLevel)
        {
            resource.Apply();
        }
    }

    [System.Serializable]
    public class ResourceSettings
    {
        public Resource Resource;
        public bool ResetResource = false;
        public int ResourceValue;

        public void Apply()
        {
            if(ResetResource)
                Resource.ResetResource();
            
            Resource.TryToAddResource(ResourceValue);
        }
    }
}
