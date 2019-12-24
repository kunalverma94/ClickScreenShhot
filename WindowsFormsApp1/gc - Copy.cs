//using System;
//using System.Drawing;
//using System.Drawing.Imaging;
//using System.Reflection;
//using System.Runtime.InteropServices;

//namespace WindowsFormsApp1
//{

//    public class gc
//    {
//        //public enum MouseKeyType
//        //{
//        //    MouseMoveOnly = 512,
//        //    MouseLeftKeyDown = 513,
//        //    MouseLeftKeyup = 514,
//        //    MouseRightKeyDown = 516,
//        //    MouseRightKeyup = 517,
//        //    MouseMiddleKeyDown = 519,
//        //    MouseMiddleKeyup = 520,
//        //    MouseScroll = 522
//        //}
//        //[StructLayout(LayoutKind.Sequential)]
//        //public class MouseEventData
//        //{
//        //    public Point point;
//        //    private int mouseData;
//        //    private int flags;
//        //    public int time;
//        //    //public int dwExtraInfo;
//        //    public bool IsScrollUp
//        //    {
//        //        get
//        //        {
//        //            return mouseData > -1;
//        //        }
//        //    }
//        //    public MouseKeyType mouseKeyType;
//        //}
//        // Event
//        //public delegate void gcMouseEvents(object source, MouseEventData e);
//        //public event gcMouseEvents gcevent;
//        // WIN32 hook
//        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
//        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);

//        //just a delegate to simplify the type of 
//        private delegate int HookProc(int nCode, int wParam, IntPtr lParam);
//        //private HookProc _hookCallback;
//        public gc()
//        {
//            //_hookCallback = new HookProc((x,y,z)=> 
//            //{
//            //    if (y==514)
//            //    {
//            //        captures();
//            //    }
//            //    return 0;
//            //});

//            SetWindowsHookEx(
//              14,
//              (x, y, z) =>
//              {
//                  if (y == 519)
//                      try
//                      {
//                          using (Bitmap bitmap = new Bitmap(1920, 1080))
//                          {
//                              Graphics.FromImage(bitmap).CopyFromScreen(Point.Empty, Point.Empty, new Size() { Height = 1080, Width = 1920 });
//                              bitmap.Save(@"D:\www\Capture" + DateTime.Now.TimeOfDay.ToString("").Replace(":", "") + ".jpg", ImageFormat.Jpeg);
//                          }
//                      }
//                      finally
//                      {
//                          GC.Collect();
//                      }

//                  return 0;
//              },
//              Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), -  0);
//        }
//    }
//}