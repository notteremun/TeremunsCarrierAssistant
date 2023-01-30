using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace TeremunsCarrierAssistant {
    public class Keyboard {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)] static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")] static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        private readonly InputSimulator vInput = new InputSimulator();
        
        public void Press(VirtualKeyCode keyCode) {
            IntPtr targetWindow = FindWindow(null, "Elite - Dangerous (Client)");
            SetForegroundWindow(targetWindow);

            vInput.Keyboard.Sleep(1000);
            
            vInput.Keyboard.KeyDown(keyCode);
            vInput.Keyboard.Sleep(250);
            vInput.Keyboard.KeyUp(keyCode);
            vInput.Keyboard.Sleep(250);
        }
        
        public void LongSpace() {
            IntPtr targetWindow = FindWindow(null, "Elite - Dangerous (Client)");
            SetForegroundWindow(targetWindow);

            vInput.Keyboard.Sleep(1000);
            
            vInput.Keyboard.KeyDown(VirtualKeyCode.SPACE);
            vInput.Keyboard.Sleep(2000);
            vInput.Keyboard.KeyUp(VirtualKeyCode.SPACE);
            vInput.Keyboard.Sleep(250);
        }
        
        public void PasteClipboard() {
            IntPtr targetWindow = FindWindow(null, "Elite - Dangerous (Client)");
            SetForegroundWindow(targetWindow);

            vInput.Keyboard.Sleep(1000);
            
            vInput.Keyboard.TextEntry(Clipboard.GetText());
            vInput.Keyboard.Sleep(250);
        }
        
        public void Sleep(int ms) {
            vInput.Keyboard.Sleep(ms);
        }
        
        
    }
}
