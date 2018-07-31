﻿using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class LightWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("SetLightDirty", SetLightDirty),
			new LuaMethod("AddCommandBuffer", AddCommandBuffer),
			new LuaMethod("AddCommandBufferAsync", AddCommandBufferAsync),
			new LuaMethod("RemoveCommandBuffer", RemoveCommandBuffer),
			new LuaMethod("RemoveCommandBuffers", RemoveCommandBuffers),
			new LuaMethod("RemoveAllCommandBuffers", RemoveAllCommandBuffers),
			new LuaMethod("GetCommandBuffers", GetCommandBuffers),
			new LuaMethod("GetLights", GetLights),
			new LuaMethod("New", _CreateLight),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("shadows", get_shadows, set_shadows),
			new LuaField("shadowStrength", get_shadowStrength, set_shadowStrength),
			new LuaField("shadowResolution", get_shadowResolution, set_shadowResolution),
			new LuaField("cookieSize", get_cookieSize, set_cookieSize),
			new LuaField("cookie", get_cookie, set_cookie),
			new LuaField("renderMode", get_renderMode, set_renderMode),
			new LuaField("lightmapBakeType", get_lightmapBakeType, set_lightmapBakeType),
			new LuaField("commandBufferCount", get_commandBufferCount, null),
			new LuaField("type", get_type, set_type),
			new LuaField("spotAngle", get_spotAngle, set_spotAngle),
			new LuaField("color", get_color, set_color),
			new LuaField("colorTemperature", get_colorTemperature, set_colorTemperature),
			new LuaField("intensity", get_intensity, set_intensity),
			new LuaField("bounceIntensity", get_bounceIntensity, set_bounceIntensity),
			new LuaField("shadowCustomResolution", get_shadowCustomResolution, set_shadowCustomResolution),
			new LuaField("shadowBias", get_shadowBias, set_shadowBias),
			new LuaField("shadowNormalBias", get_shadowNormalBias, set_shadowNormalBias),
			new LuaField("shadowNearPlane", get_shadowNearPlane, set_shadowNearPlane),
			new LuaField("range", get_range, set_range),
			new LuaField("flare", get_flare, set_flare),
			new LuaField("bakingOutput", get_bakingOutput, set_bakingOutput),
			new LuaField("cullingMask", get_cullingMask, set_cullingMask),
			new LuaField("shadowRadius", get_shadowRadius, set_shadowRadius),
			new LuaField("shadowAngle", get_shadowAngle, set_shadowAngle),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.Light", typeof(Light), regs, fields, typeof(Behaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLight(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Light obj = new Light();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Light.New");
		}

		return 0;
	}

	static Type classType = typeof(Light);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadows(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadows");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadows on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadows);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowStrength(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowStrength");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowStrength on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadowStrength);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowResolution(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowResolution");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowResolution on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadowResolution);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cookieSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cookieSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cookieSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cookieSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cookie(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cookie");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cookie on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cookie);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name renderMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index renderMode on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.renderMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lightmapBakeType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lightmapBakeType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lightmapBakeType on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.lightmapBakeType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_commandBufferCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name commandBufferCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index commandBufferCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.commandBufferCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index type on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.type);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spotAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name spotAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index spotAngle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.spotAngle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_color(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name color");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index color on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.color);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colorTemperature(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name colorTemperature");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index colorTemperature on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.colorTemperature);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_intensity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name intensity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index intensity on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.intensity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bounceIntensity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bounceIntensity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bounceIntensity on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bounceIntensity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCustomResolution(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowCustomResolution");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowCustomResolution on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadowCustomResolution);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowBias(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowBias");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowBias on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadowBias);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowNormalBias(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowNormalBias");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowNormalBias on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadowNormalBias);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowNearPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowNearPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowNearPlane on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadowNearPlane);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_range(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name range");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index range on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.range);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flare(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name flare");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index flare on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.flare);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bakingOutput(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bakingOutput");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bakingOutput on a nil value");
			}
		}

		LuaScriptMgr.PushValue(L, obj.bakingOutput);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cullingMask(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cullingMask");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cullingMask on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cullingMask);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowRadius(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowRadius");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowRadius on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadowRadius);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowAngle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.shadowAngle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadows(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadows");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadows on a nil value");
			}
		}

		obj.shadows = (LightShadows)LuaScriptMgr.GetNetObject(L, 3, typeof(LightShadows));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowStrength(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowStrength");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowStrength on a nil value");
			}
		}

		obj.shadowStrength = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowResolution(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowResolution");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowResolution on a nil value");
			}
		}

		obj.shadowResolution = (UnityEngine.Rendering.LightShadowResolution)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.LightShadowResolution));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cookieSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cookieSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cookieSize on a nil value");
			}
		}

		obj.cookieSize = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cookie(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cookie");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cookie on a nil value");
			}
		}

		obj.cookie = (Texture)LuaScriptMgr.GetUnityObject(L, 3, typeof(Texture));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderMode(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name renderMode");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index renderMode on a nil value");
			}
		}

		obj.renderMode = (LightRenderMode)LuaScriptMgr.GetNetObject(L, 3, typeof(LightRenderMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lightmapBakeType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lightmapBakeType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lightmapBakeType on a nil value");
			}
		}

		obj.lightmapBakeType = (LightmapBakeType)LuaScriptMgr.GetNetObject(L, 3, typeof(LightmapBakeType));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index type on a nil value");
			}
		}

		obj.type = (LightType)LuaScriptMgr.GetNetObject(L, 3, typeof(LightType));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spotAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name spotAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index spotAngle on a nil value");
			}
		}

		obj.spotAngle = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_color(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name color");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index color on a nil value");
			}
		}

		obj.color = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_colorTemperature(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name colorTemperature");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index colorTemperature on a nil value");
			}
		}

		obj.colorTemperature = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_intensity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name intensity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index intensity on a nil value");
			}
		}

		obj.intensity = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bounceIntensity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bounceIntensity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bounceIntensity on a nil value");
			}
		}

		obj.bounceIntensity = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCustomResolution(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowCustomResolution");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowCustomResolution on a nil value");
			}
		}

		obj.shadowCustomResolution = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowBias(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowBias");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowBias on a nil value");
			}
		}

		obj.shadowBias = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowNormalBias(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowNormalBias");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowNormalBias on a nil value");
			}
		}

		obj.shadowNormalBias = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowNearPlane(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowNearPlane");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowNearPlane on a nil value");
			}
		}

		obj.shadowNearPlane = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_range(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name range");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index range on a nil value");
			}
		}

		obj.range = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_flare(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name flare");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index flare on a nil value");
			}
		}

		obj.flare = (Flare)LuaScriptMgr.GetUnityObject(L, 3, typeof(Flare));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bakingOutput(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bakingOutput");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bakingOutput on a nil value");
			}
		}

		obj.bakingOutput = (LightBakingOutput)LuaScriptMgr.GetNetObject(L, 3, typeof(LightBakingOutput));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cullingMask(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cullingMask");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cullingMask on a nil value");
			}
		}

		obj.cullingMask = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowRadius(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowRadius");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowRadius on a nil value");
			}
		}

		obj.shadowRadius = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowAngle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		Light obj = (Light)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name shadowAngle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index shadowAngle on a nil value");
			}
		}

		obj.shadowAngle = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLightDirty(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Light obj = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Light");
		obj.SetLightDirty();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddCommandBuffer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3)
		{
			Light obj = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Light");
			UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.LightEvent));
			UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
			obj.AddCommandBuffer(arg0,arg1);
			return 0;
		}
		else if (count == 4)
		{
			Light obj = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Light");
			UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.LightEvent));
			UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
			UnityEngine.Rendering.ShadowMapPass arg2 = (UnityEngine.Rendering.ShadowMapPass)LuaScriptMgr.GetNetObject(L, 4, typeof(UnityEngine.Rendering.ShadowMapPass));
			obj.AddCommandBuffer(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Light.AddCommandBuffer");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddCommandBufferAsync(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 4)
		{
			Light obj = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Light");
			UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.LightEvent));
			UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
			UnityEngine.Rendering.ComputeQueueType arg2 = (UnityEngine.Rendering.ComputeQueueType)LuaScriptMgr.GetNetObject(L, 4, typeof(UnityEngine.Rendering.ComputeQueueType));
			obj.AddCommandBufferAsync(arg0,arg1,arg2);
			return 0;
		}
		else if (count == 5)
		{
			Light obj = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Light");
			UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.LightEvent));
			UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
			UnityEngine.Rendering.ShadowMapPass arg2 = (UnityEngine.Rendering.ShadowMapPass)LuaScriptMgr.GetNetObject(L, 4, typeof(UnityEngine.Rendering.ShadowMapPass));
			UnityEngine.Rendering.ComputeQueueType arg3 = (UnityEngine.Rendering.ComputeQueueType)LuaScriptMgr.GetNetObject(L, 5, typeof(UnityEngine.Rendering.ComputeQueueType));
			obj.AddCommandBufferAsync(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Light.AddCommandBufferAsync");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveCommandBuffer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		Light obj = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Light");
		UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.LightEvent));
		UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
		obj.RemoveCommandBuffer(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveCommandBuffers(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Light obj = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Light");
		UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.LightEvent));
		obj.RemoveCommandBuffers(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAllCommandBuffers(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Light obj = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Light");
		obj.RemoveAllCommandBuffers();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCommandBuffers(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Light obj = (Light)LuaScriptMgr.GetUnityObjectSelf(L, 1, "Light");
		UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaScriptMgr.GetNetObject(L, 2, typeof(UnityEngine.Rendering.LightEvent));
		UnityEngine.Rendering.CommandBuffer[] o = obj.GetCommandBuffers(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLights(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		LightType arg0 = (LightType)LuaScriptMgr.GetNetObject(L, 1, typeof(LightType));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		Light[] o = Light.GetLights(arg0,arg1);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

