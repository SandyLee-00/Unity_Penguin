using System;
using UnityEngine;

public class Util
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

    public static GameObject GetGameObjectByName(GameObject _gameObject, string name = null, bool recursive = false)
    {
        Transform transform = GetComponentByName<Transform>(_gameObject, name, recursive);
        if(transform == null)
        {
            return null;
        }
        return transform.gameObject;
    }

    public static T GetComponentByName<T>(GameObject _gameObject, string name = null, bool recursive = false) where T : UnityEngine.Object
    {
        if (_gameObject == null)
        {
            return null;
        }

        if(recursive == false)
        {
            Transform transform = _gameObject.transform.Find(name);
            if (transform == null)
            {
                return null;
            }
            return transform.GetComponent<T>();
        }
        else 
        {
            foreach (T component in _gameObject.GetComponentsInChildren<T>())
            {
                if (string.IsNullOrEmpty(name) || component.name == name)
                {
                    return component;
                }
            }
        }
        return null;
    }
}