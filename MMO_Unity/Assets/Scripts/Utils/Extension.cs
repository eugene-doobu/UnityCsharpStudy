using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public static class Extension
{
    public static void AddUIEvent(this GameObject go, Action<PointerEventData> action,
        Define.UIEvent type = Define.UIEvent.Click)
    {
        UI_Base.AddUIEvent(go, action, type);
    }
}
