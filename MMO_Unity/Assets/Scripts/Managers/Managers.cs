using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance;
    
    public static Managers Instance
    {
        get
        {
            Init();
            return s_instance;
        }
    }

    private InputManager _input = new InputManager();
    private ResourceManager _resource = new ResourceManager();
    private UIManager _ui = new UIManager();
    
    public static InputManager Input => Instance._input;
    public static ResourceManager Resource => Instance._resource;
    public static UIManager UI => Instance._ui;
    

    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }
            
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();   
        }
    }
}
