using System.Windows.Forms;
using WindowsInput.Native;

namespace TeremunsCarrierAssistant.FleetCarrier {
    
    //TODO: Move this into a single class with the Jump.cs
    
    public class Refuel {
        public readonly Keyboard keyboard;

        public Refuel(Keyboard keyboard) {
            this.keyboard = keyboard;
        }

        public void Perform(int neededTritium, int tritiumLocation) {
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
            keyboard.Press(VirtualKeyCode.VK_W, 4000); // Go to the top of the list
            
            for (int i = 0; i < tritiumLocation; i++) keyboard.Press(VirtualKeyCode.VK_S, 25);
            
            for (int i = 0; i < neededTritium; i++) {
                keyboard.Press(VirtualKeyCode.VK_A, 10);
            }
            keyboard.Sleep(1000);
            keyboard.Press(VirtualKeyCode.RETURN);
            keyboard.Press(VirtualKeyCode.VK_D);
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Press(VirtualKeyCode.RETURN); // Accept Transfer
            
            keyboard.Press(VirtualKeyCode.VK_Q);
            keyboard.Press(VirtualKeyCode.VK_Q);
            keyboard.Press(VirtualKeyCode.VK_Q);
            keyboard.Press(VirtualKeyCode.VK_Q);
            
            keyboard.Press(VirtualKeyCode.VK_S); // Selecting the Carrier Management back
            keyboard.Press(VirtualKeyCode.VK_D);
            
            keyboard.Press(VirtualKeyCode.VK_4); // Close right panel
            keyboard.Press(VirtualKeyCode.SPACE);
            keyboard.Sleep(3500);
            keyboard.Press(VirtualKeyCode.VK_S);
            keyboard.Press(VirtualKeyCode.VK_S);

            keyboard.Press(VirtualKeyCode.SPACE); // Open Tritium Depot
            keyboard.Press(VirtualKeyCode.SPACE); // Donate Tritium Click
            keyboard.Press(VirtualKeyCode.VK_W); 
            keyboard.Press(VirtualKeyCode.SPACE); // Confirm Tritium Deposit

            keyboard.Press(VirtualKeyCode.RETURN);
            keyboard.Press(VirtualKeyCode.RETURN);
            keyboard.Press(VirtualKeyCode.RETURN);
        }
    }
}
