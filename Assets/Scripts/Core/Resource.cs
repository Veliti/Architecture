using UnityEngine;

public abstract class Resource<T> : MonoBehaviour where T: Resource<T>
{
    public static T ResourceInstance {get => _instance;}
    public abstract bool TryToUseResource();

    private static T _instance;

    private void OnEnable()
    {
        if(_instance == null)
        {
            _instance = GetComponent<T>();
        }
        else
        {
            Destroy(this);
        }
    }
}
