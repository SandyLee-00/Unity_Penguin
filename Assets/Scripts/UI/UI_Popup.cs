﻿

public class UI_Popup : UI_Base
{
    public override bool Init()
    {
        if (base.Init() == false)
        {
            return false;
        }

        Managers.UI.SetCanvas(gameObject, true);
        return true;
    }
}