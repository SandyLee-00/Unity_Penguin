using UnityEngine;

public class Utils
{
    public static T GetOrAddComponent<T>(GameObject _gameobject) where T : UnityEngine.Component
    {
        T component = _gameobject.GetComponent<T>();
        if (component == null)
        {
            component = _gameobject.AddComponent<T>();
        }
        return component;
    }
}