using System.Windows.Forms;
using WindowsInput.Native;

namespace TeremunsCarrierAssistant.FleetCarrier {
    
    public class Refuel {
        public readonly Keyboard keyboard;
        private int tritiumLocation;
        private Label debugLabel;
        
        public Refuel(Keyboard keyboard, Label debugLabel, int tritiumLocation) {
            this.keyboard = keyboard;
            this.debugLabel = debugLabel;
            this.tritiumLocation = tritiumLocation;
        }
        
        
        public void Perform() {
            debugLabel.Text = "Refueling: Opening the right panel...";
            keyboard.Press(VirtualKeyCode.VK_4); // Open right panel
            keyboard.Sleep(1000);

            debugLabel.Text = "Refueling: Navigating to inventory tab...";
            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.Sleep(500);
            
            debugLabel.Text = "Refueling: Going to the transfer tab...";
            keyboard.Press(VirtualKeyCode.VK_D);
            keyboard.Press(VirtualKeyCode.VK_D);
            keyboard.Press(VirtualKeyCode.SPACE);
            for (int i = 0; i < 50; i++) keyboard.Press(VirtualKeyCode.VK_W);
            
            debugLabel.Text = "Refueling: Selecting Tritium...";
            for (int i = 0; i < tritiumLocation; i++) keyboard.Press(VirtualKeyCode.VK_S);
            
            for (int i = 0; i < 250; i++) {
                debugLabel.Text = "Refueling: Trying transferring " + ( i + 1 ) + "/"+ 250 +" Tritium...";
                keyboard.Press(VirtualKeyCode.VK_A);
            }
            keyboard.Press(VirtualKeyCode.VK_S);
            keyboard.Press(VirtualKeyCode.VK_D);
            keyboard.Press(VirtualKeyCode.RETURN);
            keyboard.Press(VirtualKeyCode.VK_4);
            
            debugLabel.Text = "Refueling: Opening Carrier Services...";
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Sleep(3500);
            keyboard.Press(VirtualKeyCode.VK_S);
            keyboard.Press(VirtualKeyCode.VK_S);

            debugLabel.Text = "Refueling: Opening Tritium Depot...";
            keyboard.Press(VirtualKeyCode.SPACE);

        }
    }
}
