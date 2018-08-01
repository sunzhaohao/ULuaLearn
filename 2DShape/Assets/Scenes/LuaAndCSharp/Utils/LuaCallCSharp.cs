using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
public class LuaCallCSharp
{

    private LuaState luaState = new LuaState();

    public string GetArgumentsScript(object[] arguments)
    {
        string allParams = "";
        if (arguments != null)
        {
            for (int i = 0; i < arguments.Length; i++)
            {
                if (i == 0)
                    allParams += "(";
                allParams += arguments[i];
                if (i < arguments.Length - 1)
                    allParams += ",";
                else allParams += ")";
            }
        }
        
        return allParams;
    }
   
    // 静态方法
    public object CallStaticFunc(string script, object csObject, string funcName, object[] arguments)
    {
        luaState.DoString(script);
        ////注册静态方法
        luaState.RegisterFunction(funcName, null, csObject.GetType().GetMethod(funcName));

        string allParams = GetArgumentsScript(arguments);
        luaState.DoString(" result=" + funcName + allParams);

        object result = luaState["result"];
        return result;
    }

    // 不能调用静态方法
    public object CallFunction(string script,object csObject, string funcName, object[] arguments)
    {
        luaState.DoString(script);
        string getRefFunc = "getRef";
        luaState.RegisterFunction(getRefFunc, csObject, csObject.GetType().GetMethod(getRefFunc));
   
        luaState.DoString("csObj=getRef()");
        string allParams = GetArgumentsScript(arguments);
        luaState.DoString(" result=csObj:" + funcName + allParams);
    
        return luaState["result"];
    }

}
