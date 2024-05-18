using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class UI_Base : MonoBehaviour
{
    protected bool _init = false;

    protected Dictionary<Type, UnityEngine.Object[]> objectDictionary = new Dictionary<Type, UnityEngine.Object[]>();

    private void Start()
    {
        Init();
    }

    public virtual bool Init()
    {
        if(_init)
        {
            return false;
        }

        return _init = true;
    }

    protected void BindObject(Type type) { Bind<GameObject>(type); }

    protected void Bind<T>(Type type) where T : UnityEngine.Object
    {
        string[] names = Enum.GetNames(type);
        UnityEngine.Object[] objects = new UnityEngine.Object[names.Length];
        objectDictionary.Add(typeof(T), objects);

        for (int i = 0; i < names.Length; i++)
        {
            if (typeof(T) == typeof(GameObject))
            {
                objects[i] = Util.GetGameObjectByName(gameObject, names[i], true);
            }
            else
            {
                objects[i] = Util.GetComponentByName<T>(gameObject, names[i], true);
            }

            if (objects[i] == null)
            {
                Debug.LogError($"Failed to bind object of type {typeof(T)} with name {names[i]}");
            }
        }

    }
}