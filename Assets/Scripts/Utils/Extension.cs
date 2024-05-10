using UnityEngine;

public static class Extension
{
    public static bool IsValid(this GameObject gameObject)
    {
        return gameObject != null && gameObject.activeSelf;
    }
}