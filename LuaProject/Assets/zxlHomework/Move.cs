using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
public class Move : MonoBehaviour
{
    private LuaEnv luaenv = new LuaEnv();


    [CSharpCallLua]
    private delegate void Del();
    [CSharpCallLua]
    private delegate void Set(Move move);
    private Del update;

    void Start()
    {
        luaenv.DoString("require 'zxlMove'");
        Set set = luaenv.Global.Get<Set>("Set");
        set(this);
        update = luaenv.Global.Get<Del>("Update");
    }

    void Update()
    {
        if (null != update)
        {
            update();
        }
    }


    private void OnDestroy()
    {
        update = null;
        luaenv.Dispose();
    }
}
