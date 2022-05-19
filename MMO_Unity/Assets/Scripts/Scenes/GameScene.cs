using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    protected override void Init()
    {
        base.Init();
        SceneType = Define.Scene.Game;

        Dictionary<int, Data.Stat> dict = Managers.Data.StatDict;

        gameObject.GetOrAddComponent<CursorController>();
    }

    public override void Clear()
    {
        throw new System.NotImplementedException();
    }
}
