using System.Windows.Forms;
using WindowsInput.Native;

namespace TeremunsCarrierAssistant.FleetCarrier {
    
    public class Refuel {
        public readonly Keyboard keyboard;
        private int tritiumLocation;

        public Refuel(Keyboard keyboard, int tritiumLocation) {
            this.keyboard = keyboard;
            this.tritiumLocation = tritiumLocation;
        }
        
        
        public void Perform(int neededTritium) {
            keyboard.Press(VirtualKeyCode.VK_4); // Open right panel
            keyboard.Sleep(1000);

            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.Press(VirtualKeyCode.VK_E);
            keyboard.Sleep(500);
            
            keyboard.Press(VirtualKeyCode.VK_D);
            keyboard.Press(VirtualKeyCode.VK_D);
            keyboard.Press(VirtualKeyCode.SPACE);
            for (int i = 0; i < 50; i++) keyboard.Press(VirtualKeyCode.VK_W);
            
            for (int i = 0; i < tritiumLocation; i++) keyboard.Press(VirtualKeyCode.VK_S);
            
            for (int i = 0; i < neededTritium; i++) {
                keyboard.Press(VirtualKeyCode.VK_A);
            }
            keyboard.Press(VirtualKeyCode.VK_S);
            keyboard.Press(VirtualKeyCode.VK_D);
            keyboard.Press(VirtualKeyCode.RETURN);
            keyboard.Press(VirtualKeyCode.VK_4);
            
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Sleep(3500);
            keyboard.Press(VirtualKeyCode.VK_S);
            keyboard.Press(VirtualKeyCode.VK_S);

            keyboard.Press(VirtualKeyCode.SPACE);

        }
    }
}
