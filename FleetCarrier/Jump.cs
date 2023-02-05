using System.Reflection.Emit;
using System.Windows.Forms;
using WindowsInput.Native;
using Label = System.Windows.Forms.Label;

namespace TeremunsCarrierAssistant.FleetCarrier {
    public class Jump {
        public readonly Keyboard keyboard;
        private int buffer;
        
        public Jump(Keyboard keyboard, int buffer) {
            this.keyboard = keyboard;
            this.buffer = buffer;
        }

        public void Perform(string systemName) {
            keyboard.Press(VirtualKeyCode.VK_4);       // Open right panel
            keyboard.Sleep(1000);
            
            keyboard.Press(VirtualKeyCode.SPACE);      // Opens Carrier Management
            keyboard.Sleep(7000);
            
            keyboard.Press(VirtualKeyCode.VK_S);       // Opens Navigation Panel
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Sleep(buffer);
            
            keyboard.Press(VirtualKeyCode.UP);         // Navigate to the search bar and paste content
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.PasteClipboard(systemName);
            keyboard.Sleep(250);
            keyboard.Press(VirtualKeyCode.DOWN);
            keyboard.Sleep(250);
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Sleep(7000);
            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.LongSpace();
            keyboard.Sleep(buffer);
            
            keyboard.Press(VirtualKeyCode.BACK);
        }
    }
}
