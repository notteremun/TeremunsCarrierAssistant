using WindowsInput.Native;

namespace TeremunsCarrierAssistant.FleetCarrier {
    public class Jump {
        private readonly Keyboard keyboard;
        
        public Jump(Keyboard keyboard) {
            this.keyboard = keyboard;
        }

        public void Perform() {
            keyboard.Press(VirtualKeyCode.VK_4);       // Open right panel
            keyboard.Sleep(1000);
            
            keyboard.Press(VirtualKeyCode.SPACE);      // Opens Carrier Management
            keyboard.Sleep(7000);
            
            keyboard.Press(VirtualKeyCode.VK_S);       // Opens Navigation Panel
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Sleep(7000);
            
            keyboard.Press(VirtualKeyCode.UP);         // Navigate to the search bar and paste content
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.PasteClipboard();
            keyboard.Sleep(250);
            keyboard.Press(VirtualKeyCode.DOWN);
            keyboard.Sleep(250);
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Sleep(250);
            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.LongSpace();
            keyboard.Sleep(15000);
            
            keyboard.Press(VirtualKeyCode.BACK);
            keyboard.Sleep(2500);
            keyboard.Press(VirtualKeyCode.BACK);
            
        }
    }
}
