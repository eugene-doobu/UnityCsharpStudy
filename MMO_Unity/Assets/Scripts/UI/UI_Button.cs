using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using Object = UnityEngine.Object;

public class UI_Button : UI_Base
{
    
    enum Buttons
    {
        PointButton
    }
    
    enum Texts
    {
        PointText,
        ScoreText
    }

    enum GameObjects
    {
        TestObject,
    }

    enum Images
    {
        ItemIcon,
    }

    private void Start()
    {
        Bind<Button>(typeof(Buttons));
        Bind<Text>(typeof(Texts));
        Bind<GameObject>(typeof(GameObjects));
        Bind<Image>(typeof(Images));

        Get<Text>((int) Texts.ScoreText).text = "Bind Test";
        GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        UI_EventHandler evt = go.GetComponent<UI_EventHandler>();
        evt.OnDragHandler += ((PointerEventData data) =>
        {
            go.transform.position = data.position;
        });
    }

    private int _score = 0;
    
    public void OnButtonClicked()
    {
        _score++;
    }
}
