using System.Runtime.InteropServices;

namespace AlwaysAvailable;

public class Keyboard
{
    [DllImport("user32.dll", SetLastError = true)]
    static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
    const int KEY_UP_EVENT = 0x0002; //Key up flag

    public static void KeyUp(byte key)
    {
        keybd_event(key, 0, KEY_UP_EVENT, 0);
    }
}
