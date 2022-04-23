using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using Object = UnityEngine.Object;

public class UI_Button : UI_Popup
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
        
        GetButton((int)Buttons.PointButton).gameObject.AddUIEvent(OnButtonClicked);
        
        GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        AddUIEvent(go, (data) => { go.transform.position = data.position; }, Define.UIEvent.Drag);
    }

    private int _score = 0;
    
    public void OnButtonClicked(PointerEventData data)
    {
        _score++;
        Get<Text>((int) Texts.ScoreText).text = $"점수 : {_score}";
    }
}
