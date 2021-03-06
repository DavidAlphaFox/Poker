﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIAPIWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("UIAPI");
		L.RegFunction("Init", Init);
		L.RegFunction("DebugLog", DebugLog);
		L.RegFunction("CloseAll", CloseAll);
		L.RegFunction("SetToCenter", SetToCenter);
		L.RegFunction("CreateUI", CreateUI);
		L.RegFunction("CreateUIEx", CreateUIEx);
		L.RegFunction("CloneUI", CloneUI);
		L.RegFunction("DeleteUI", DeleteUI);
		L.RegFunction("DeletetAllChild", DeletetAllChild);
		L.RegFunction("CreateChild", CreateChild);
		L.RegFunction("ShowOne", ShowOne);
		L.RegFunction("CloseOne", CloseOne);
		L.RegFunction("CloneChildCount", CloneChildCount);
		L.RegFunction("ClearInput", ClearInput);
		L.RegFunction("SetText", SetText);
		L.RegFunction("SetToggle", SetToggle);
		L.RegFunction("SetImage", SetImage);
		L.RegFunction("SetEmImage", SetEmImage);
		L.RegFunction("SetImageColor", SetImageColor);
		L.RegFunction("SetTextColor", SetTextColor);
		L.RegFunction("SliderValue", SliderValue);
		L.RegFunction("SliderCount", SliderCount);
		L.RegFunction("SetArtNumber", SetArtNumber);
		L.RegFunction("SetArtNumber2", SetArtNumber2);
		L.RegFunction("SetNumberImage", SetNumberImage);
		L.RegFunction("ShowEffect", ShowEffect);
		L.RegFunction("ShowImageEffect", ShowImageEffect);
		L.RegFunction("ShowImageEffectColor", ShowImageEffectColor);
		L.RegFunction("SetOnClick", SetOnClick);
		L.RegFunction("Gray", Gray);
		L.RegFunction("SetPaiEx", SetPaiEx);
		L.RegFunction("SetY", SetY);
		L.RegVar("gCanvas", get_gCanvas, set_gCanvas);
		L.RegVar("emsList", get_emsList, set_emsList);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UIAPI.Init();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DebugLog(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UIAPI.DebugLog(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UIAPI.CloseAll();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetToCenter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
			UIAPI.SetToCenter(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateUI(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				UnityEngine.Transform o = UIAPI.CreateUI(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(bool)))
			{
				string arg0 = ToLua.ToString(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				UnityEngine.Transform o = UIAPI.CreateUI(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UIAPI.CreateUI");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateUIEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.Transform o = UIAPI.CreateUIEx(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloneUI(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			UnityEngine.Transform o = UIAPI.CloneUI(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeleteUI(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UIAPI.DeleteUI(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeletetAllChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			UIAPI.DeletetAllChild(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			string arg1 = ToLua.CheckString(L, 2);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
			UnityEngine.Transform o = UIAPI.CreateChild(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowOne(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.Transform o = UIAPI.ShowOne(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseOne(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UIAPI.CloseOne(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloneChildCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UIAPI.CloneChildCount(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearInput(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			UIAPI.ClearInput(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetText(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			string arg1 = ToLua.CheckString(L, 2);
			UIAPI.SetText(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetToggle(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(bool)))
			{
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				UIAPI.SetToggle(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(int)))
			{
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				UIAPI.SetToggle(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UIAPI.SetToggle");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetImage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			string arg1 = ToLua.CheckString(L, 2);
			UIAPI.SetImage(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetEmImage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UIAPI.SetEmImage(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetImageColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			byte arg1 = (byte)LuaDLL.luaL_checknumber(L, 2);
			byte arg2 = (byte)LuaDLL.luaL_checknumber(L, 3);
			byte arg3 = (byte)LuaDLL.luaL_checknumber(L, 4);
			UIAPI.SetImageColor(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTextColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			byte arg1 = (byte)LuaDLL.luaL_checknumber(L, 2);
			byte arg2 = (byte)LuaDLL.luaL_checknumber(L, 3);
			byte arg3 = (byte)LuaDLL.luaL_checknumber(L, 4);
			UIAPI.SetTextColor(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SliderValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UIAPI.SliderValue(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SliderCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UIAPI.SliderCount(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetArtNumber(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UIAPI.SetArtNumber(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetArtNumber2(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UIAPI.SetArtNumber2(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetNumberImage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UIAPI.SetNumberImage(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowEffect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			string arg1 = ToLua.CheckString(L, 2);
			UnityEngine.Transform o = UIAPI.ShowEffect(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowImageEffect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			UnityEngine.Transform o = UIAPI.ShowImageEffect(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowImageEffectColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			byte arg3 = (byte)LuaDLL.luaL_checknumber(L, 4);
			byte arg4 = (byte)LuaDLL.luaL_checknumber(L, 5);
			byte arg5 = (byte)LuaDLL.luaL_checknumber(L, 6);
			UIAPI.ShowImageEffectColor(arg0, arg1, arg2, arg3, arg4, arg5);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetOnClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);
			UIAPI.SetOnClick(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Gray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			UIAPI.Gray(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPaiEx(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UIAPI.SetPaiEx(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetY(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			UIAPI.SetY(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gCanvas(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UIAPI.gCanvas);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_emsList(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UIAPI.emsList);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_gCanvas(IntPtr L)
	{
		try
		{
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
			UIAPI.gCanvas = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_emsList(IntPtr L)
	{
		try
		{
			ImageList arg0 = (ImageList)ToLua.CheckUnityObject(L, 2, typeof(ImageList));
			UIAPI.emsList = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

