using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class GameManager : MonoBehaviour
{
    LuaEnv luaenv = null;
    void Awake()
    {
        luaenv = new LuaEnv();
        
        luaenv.AddLoader((ref string filepath) =>
        {
            filepath = Application.dataPath + "/Scripts/lua/" + filepath.Replace('.', '/') + ".lua";
            if (File.Exists(filepath))
            {
                return File.ReadAllBytes(filepath);
            }
            else
            {
                return null;
            }
        });

        luaenv.DoString(@"require 'main'");

    }

    void OnDestroy()
    {
        luaenv.Dispose();
    }
}
