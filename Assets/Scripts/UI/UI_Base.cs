using UnityEngine;

public abstract class UI_Base : MonoBehaviour
{
    protected bool _init = false;

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
}