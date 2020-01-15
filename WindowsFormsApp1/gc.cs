using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{

    public class gc
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);
        private delegate int HookProc(int nCode, int wParam, IntPtr lParam);

        public gc()
        {


            SetWindowsHookEx(
              14,
              (x, y, z) =>
              { if (y == 513)
                      try
                      {using (Bitmap bitmap = new Bitmap(1920, 1080))
                          {
                              Graphics.FromImage(bitmap).CopyFromScreen(Point.Empty, Point.Empty, new Size() { Height = 1080, Width = 1920 });
                              bitmap.Save(@"C:\Users\kunal.verma\temp\Capture" + DateTime.Now.TimeOfDay.ToString("").Replace(":", "") + ".dmp", ImageFormat.Jpeg);
                          }
                      }
                      finally
                      {
                          GC.Collect();
                      }

                  return 0;
              },
              Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), -  0);
        }
    }
}