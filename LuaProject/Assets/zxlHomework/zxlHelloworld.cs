﻿using UnityEngine;
using XLua;

namespace XLuaTest
{
    public class zxlHelloworld : MonoBehaviour
    {
        void Start()
        {
            LuaEnv luaenv = new LuaEnv();
            luaenv.DoString("CS.UnityEngine.Debug.Log('hello world')");
            luaenv.Dispose();
        }
    }
}
