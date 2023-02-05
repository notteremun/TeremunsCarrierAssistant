using System.Reflection.Emit;
using System.Windows.Forms;
using WindowsInput.Native;
using Label = System.Windows.Forms.Label;

namespace TeremunsCarrierAssistant.FleetCarrier {
    public class Jump {
        public readonly Keyboard keyboard;
        private Label debugLabel;
        private int buffer;
        
        public Jump(Keyboard keyboard, Label debugLabel, int buffer) {
            this.keyboard = keyboard;
            this.debugLabel = debugLabel;
            this.buffer = buffer;
        }

        public void Perform() {
            debugLabel.Text = "Jumping: Opening the right panel...";
            keyboard.Press(VirtualKeyCode.VK_4);       // Open right panel
            keyboard.Sleep(1000);
            
            debugLabel.Text = "Jumping: Opening the the carrier mangement panel...";
            keyboard.Press(VirtualKeyCode.SPACE);      // Opens Carrier Management
            keyboard.Sleep(7000);
            
            debugLabel.Text = "Jumping: Navigating to Navigation...";
            keyboard.Press(VirtualKeyCode.VK_S);       // Opens Navigation Panel
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Sleep(buffer);
            
            debugLabel.Text = "Jumping: Searching and plotting for the system...";
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
            keyboard.Sleep(buffer * 2);
            
            debugLabel.Text = "Jumping: Backing out of the carrier management screen...";
            keyboard.Press(VirtualKeyCode.BACK);
            keyboard.Sleep(2500);
            keyboard.Press(VirtualKeyCode.BACK);
            
        }
    }
}
