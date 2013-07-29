#region CopyRight
/**************************************************************
   Copyright (c) 2012 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.269
   命名空间名称   :    WebSample
   文件名         :    Utility
   创建时间       :    2012/6/29 16:47:35
   用户所在的域   :    SWKEJIT410
   登录用户名     :    Star
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.Web;
using JdSdk;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WinFormsSample
{
    public class Utility
    {
        private const String ErrorTitle = "错误";
        private const String InfoTitle = "信息";

        public static DialogResult ShowError(string message)
        {
            DialogResult result = MessageBox.Show(message, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result;
        }

        public static DialogResult ShowInfo(string message)
        {
            DialogResult result = MessageBox.Show(message, InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }

        /// <summary>
        /// 分配Console到指定控件
        /// <para>未完成,样式有问题</para>
        /// </summary>
        /// <param name="control"></param>
        public static void AllocConsole(Control control)
        {
            if (control == null) return;

            Utility.AllocConsole();
            //cmd的名称和应用程序路劲名一致
            IntPtr consoleHandle = Utility.FindWindow(null, Process.GetCurrentProcess().MainModule.FileName);
            Utility.SetParent(consoleHandle, control.Handle);

            try
            {
                SetParent(consoleHandle, control.Handle);
            }
            catch (Exception)
            { }
            try
            {
                SetWindowLong(new HandleRef(control, consoleHandle), GWL_STYLE, WS_VISIBLE);
            }
            catch (Exception)
            { }
            try
            {
                MoveWindow(consoleHandle, 0, 0, control.Width, control.Height, true);
                control.Resize += (ctr, e) => { MoveWindow(consoleHandle, 0, 0, control.Width, control.Height, true); };
            }
            catch (Exception)
            { }

        }

        /// <summary>
        /// 执行其他程序
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Boolean Run(String fileName, String args)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName");
            }

            using (var proc = new Process())
            {
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.Arguments = args;
                proc.StartInfo.Verb = "open";
                proc.StartInfo.UseShellExecute = true;
                return proc.Start();
            }
        }

        /// <summary>
        /// 判断系统是否64位
        /// </summary>
        /// <returns></returns>
        public static Boolean Is64BitOperatingSystem()
        {
            return IntPtr.Size == 8;
        }

        #region DllImport
        /// <summary>
        /// 分配窗口
        /// </summary>
        /// <returns></returns>
        [DllImport("Kernel32.dll")]
        internal static extern Boolean AllocConsole();

        /// <summary>
        /// 释放窗口
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "FreeConsole")]
        internal static extern Boolean FreeConsole();

        /// <summary>
        /// 查找窗口
        /// </summary>
        /// <param name="lpClassName"></param>
        /// <param name="lpWindowName"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        internal extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 取出窗口运行的菜单
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="bRevert"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
        internal extern static IntPtr GetSystemMenu(IntPtr hWnd, IntPtr bRevert);

        /// <summary>
        /// 灰掉按钮
        /// </summary>
        /// <param name="hMenu">菜单句柄</param>
        /// <param name="uPosition"></param>
        /// <param name="uFlags"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        internal extern static IntPtr RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

        /// <summary>
        /// 设置标题
        /// </summary>
        /// <param name="strMessage"></param>
        /// <returns></returns>
        [DllImport("Kernel32.dll")]
        internal static extern Boolean SetConsoleTitle(string strMessage);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern Int64 SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        internal const Int32 GWL_STYLE = (-16);
        internal const Int64 WS_VISIBLE = 0x10000000;

        /// <summary>
        /// 设置窗口属性
        /// </summary>
        internal static IntPtr SetWindowLong(HandleRef hWnd, Int32 nIndex, Int64 dwNewLong)
        {
            if (IntPtr.Size == 4)
            {
                return SetWindowLongPtr32(hWnd, nIndex, dwNewLong);
            }
            return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
        }

        /// <summary>
        /// 设置窗口属性
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        private static extern IntPtr SetWindowLongPtr32(HandleRef hWnd, Int32 nIndex, Int64 dwNewLong);

        /// <summary>
        /// 设置窗口属性
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr", CharSet = CharSet.Auto)]
        private static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, Int32 nIndex, Int64 dwNewLong);

        /// <summary>
        /// 设置窗体位置
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="hWndInsertAfter"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        /// <param name="wFlags"></param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        private static extern long SetWindowPos(IntPtr hwnd, Int64 hWndInsertAfter, Int64 x, Int64 y, Int64 cx, Int64 cy, Int64 wFlags);

        /// <summary>
        /// 移动窗体到指定位置
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        /// <param name="repaint"></param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        private static extern Boolean MoveWindow(IntPtr hwnd, Int32 x, Int32 y, Int32 cx, Int32 cy, Boolean repaint);

        /// <summary>
        /// 发送windows消息
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "PostMessageA", SetLastError = true)]
        private static extern Boolean PostMessage(IntPtr hwnd, UInt32 Msg, UInt32 wParam, UInt32 lParam);

        /// <summary>
        /// 获取父句柄
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetParent(IntPtr hwnd);

        #endregion
    }
}





