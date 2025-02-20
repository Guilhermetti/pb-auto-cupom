using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace AutoCupom
{
    public class InputSimulator
    {
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int KEYEVENTF_KEYDOWN = 0x0000;
        private const int KEYEVENTF_KEYUP = 0x0002;

        public static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Task.Delay(10).Wait();
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public static void PressKey(byte keyCode)
        {
            keybd_event(keyCode, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(keyCode, 0, KEYEVENTF_KEYUP, 0);
        }

        public static void CtrlC()
        {
            keybd_event(0x11, 0, KEYEVENTF_KEYDOWN, 0); // Ctrl
            keybd_event(0x43, 0, KEYEVENTF_KEYDOWN, 0); // C
            keybd_event(0x43, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(0x11, 0, KEYEVENTF_KEYUP, 0);
        }

        public static void CtrlV()
        {
            keybd_event(0x11, 0, KEYEVENTF_KEYDOWN, 0); // Ctrl
            keybd_event(0x56, 0, KEYEVENTF_KEYDOWN, 0); // V
            keybd_event(0x56, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(0x11, 0, KEYEVENTF_KEYUP, 0);
        }

        public static void AltTab()
        {
            keybd_event(0x12, 0, KEYEVENTF_KEYDOWN, 0); // Alt
            keybd_event(0x09, 0, KEYEVENTF_KEYDOWN, 0); // Tab
            keybd_event(0x09, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(0x12, 0, KEYEVENTF_KEYUP, 0);
        }

        public static void PressEnter()
        {
            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0); // Enter
            keybd_event(0x0D, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
