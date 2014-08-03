﻿using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.Reflection;
using System.IO;
using System.Globalization;

namespace LuaDebugger
{
    public static class DebuggerDllExports
    {
        static DebuggerDllExports()
        {
            if (!Application.ExecutablePath.ToLower().Contains(GlobalState.SettlersExe))
            {
                MessageBox.Show("This DLL only works with " + GlobalState.SettlersExe);
                Environment.Exit(0);
            }

            ErrorHook.InstallHook();
            Thread uiThread = new Thread(new ThreadStart(DbgThread.RunMessageLoop));
            uiThread.SetApartmentState(ApartmentState.STA);
            uiThread.Start();
            GlobalState.UIThread = uiThread;
        }

        static int s5StateCount = 0;
        //S5
        [DllExport("_AddLuaState@4", CallingConvention = CallingConvention.StdCall)]
        public static void AddLuaState(UIntPtr L)
        {
            s5StateCount++;
            string name = s5StateCount == 1 ? "Main Menu" : "Game";

            lock (GlobalState.GuiUpdateLock)
            {
                LuaState ls = new LuaState(L, name);
                GlobalState.L2State.Add(L, ls);
                GlobalState.LuaStates.Add(ls);
                GlobalState.UpdateStatesView = true;
            }
        }

        //S6
        [DllExport("_AddLuaState@8", CallingConvention = CallingConvention.StdCall)]
        public static void AddLuaStateS6(UIntPtr L, string name)
        {
            lock (GlobalState.GuiUpdateLock)
            {
                TextInfo ti = Thread.CurrentThread.CurrentCulture.TextInfo;
                LuaState ls = new LuaState(L, ti.ToTitleCase(name));
                GlobalState.L2State.Add(L, ls);
                GlobalState.LuaStates.Add(ls);
                GlobalState.UpdateStatesView = true;
            }
        }

        [DllExport("_RemoveLuaState@4", CallingConvention = CallingConvention.StdCall)]
        public static void RemoveLuaState(UIntPtr L)
        {
            lock (GlobalState.GuiUpdateLock)
            {
                LuaState ls = GlobalState.L2State[L];
                GlobalState.L2State.Remove(L);
                GlobalState.LuaStates.Remove(ls);
                ErrorHook.RemoveErrorHandler(L); // todo: refactor into luastate?
                GlobalState.UpdateStatesView = true;
            }
        }

        [DllExport("_NewFile@16", CallingConvention = CallingConvention.StdCall)]
        public static void NewFile(UIntPtr L, string filename, IntPtr content, int contentLen)
        {
            if (filename == null)
                return;//Immediate Action

            LuaState ls = GlobalState.L2State[L];

            if (ls.LoadedFiles.ContainsKey(filename))
                return;

            lock (GlobalState.GuiUpdateLock)
            {
                string fileContents = Marshal.PtrToStringAnsi(content, contentLen);
                ls.LoadedFiles.Add(filename, new LuaFile(filename, fileContents));
                ls.UpdateFileList = true;
            }

        }

        [DllExport("_Show@0", CallingConvention = CallingConvention.StdCall)]
        public static void Show()
        {
            //MessageBox.Show("show");
        }

        [DllExport("_Hide@0", CallingConvention = CallingConvention.StdCall)]
        public static void Hide()
        {
            //MessageBox.Show("hide");
        }

        [DllExport("_Break@4", CallingConvention = CallingConvention.StdCall)]
        public static void Break(UIntPtr L)
        {
            GlobalState.L2State[L].DebugEngine.BreakFromGameEngine();
        }

        [DllExport("_ShowExecuteLine@0", CallingConvention = CallingConvention.StdCall)]
        public static void ShowExecuteLine()
        {
            //MessageBox.Show("ShowExecuteLine");
        }

        //S6
        [DllExport("_IsBreaked@0", CallingConvention = CallingConvention.StdCall)]
        public static int IsBreaked()
        {
            return GlobalState.FreezeCount;
        }
    }
}
