﻿using System;
using UnityEngine;
using LuaInterface;

public class ScreenWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("SetResolution", SetResolution),
			new LuaMethod("New", _CreateScreen),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("width", get_width, null),
			new LuaField("height", get_height, null),
			new LuaField("dpi", get_dpi, null),
			new LuaField("orientation", get_orientation, set_orientation),
			new LuaField("sleepTimeout", get_sleepTimeout, set_sleepTimeout),
			new LuaField("autorotateToPortrait", get_autorotateToPortrait, set_autorotateToPortrait),
			new LuaField("autorotateToPortraitUpsideDown", get_autorotateToPortraitUpsideDown, set_autorotateToPortraitUpsideDown),
			new LuaField("autorotateToLandscapeLeft", get_autorotateToLandscapeLeft, set_autorotateToLandscapeLeft),
			new LuaField("autorotateToLandscapeRight", get_autorotateToLandscapeRight, set_autorotateToLandscapeRight),
			new LuaField("currentResolution", get_currentResolution, null),
			new LuaField("fullScreen", get_fullScreen, set_fullScreen),
			new LuaField("fullScreenMode", get_fullScreenMode, set_fullScreenMode),
			new LuaField("safeArea", get_safeArea, null),
			new LuaField("resolutions", get_resolutions, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Screen", typeof(Screen), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateScreen(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Screen obj = new Screen();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Screen.New");
		}

		return 0;
	}

	static Type classType = typeof(Screen);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.width);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.height);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dpi(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.dpi);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_orientation(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.orientation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sleepTimeout(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.sleepTimeout);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToPortrait(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.autorotateToPortrait);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToPortraitUpsideDown(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.autorotateToPortraitUpsideDown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToLandscapeLeft(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.autorotateToLandscapeLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToLandscapeRight(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.autorotateToLandscapeRight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentResolution(IntPtr L)
	{
		LuaScriptMgr.PushValue(L, Screen.currentResolution);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fullScreen(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.fullScreen);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fullScreenMode(IntPtr L)
	{
		LuaScriptMgr.Push(L, Screen.fullScreenMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_safeArea(IntPtr L)
	{
		LuaScriptMgr.PushValue(L, Screen.safeArea);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resolutions(IntPtr L)
	{
		LuaScriptMgr.PushArray(L, Screen.resolutions);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_orientation(IntPtr L)
	{
		Screen.orientation = (ScreenOrientation)LuaScriptMgr.GetNetObject(L, 3, typeof(ScreenOrientation));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sleepTimeout(IntPtr L)
	{
		Screen.sleepTimeout = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToPortrait(IntPtr L)
	{
		Screen.autorotateToPortrait = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToPortraitUpsideDown(IntPtr L)
	{
		Screen.autorotateToPortraitUpsideDown = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToLandscapeLeft(IntPtr L)
	{
		Screen.autorotateToLandscapeLeft = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToLandscapeRight(IntPtr L)
	{
		Screen.autorotateToLandscapeRight = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fullScreen(IntPtr L)
	{
		Screen.fullScreen = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fullScreenMode(IntPtr L)
	{
		Screen.fullScreenMode = (FullScreenMode)LuaScriptMgr.GetNetObject(L, 3, typeof(FullScreenMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetResolution(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(int), typeof(bool)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			bool arg2 = LuaDLL.lua_toboolean(L, 3);
			Screen.SetResolution(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(int), typeof(FullScreenMode)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			FullScreenMode arg2 = (FullScreenMode)LuaScriptMgr.GetLuaObject(L, 3);
			Screen.SetResolution(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(int), typeof(FullScreenMode), typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			FullScreenMode arg2 = (FullScreenMode)LuaScriptMgr.GetLuaObject(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			Screen.SetResolution(arg0,arg1,arg2,arg3);
			return 0;
		}
		else if (count == 4 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(int), typeof(bool), typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			bool arg2 = LuaDLL.lua_toboolean(L, 3);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
			Screen.SetResolution(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Screen.SetResolution");
		}

		return 0;
	}
}

