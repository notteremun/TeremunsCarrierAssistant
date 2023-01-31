using System.Windows.Forms;
using WindowsInput.Native;

namespace TeremunsCarrierAssistant.FleetCarrier {
    
    public class Refuel {
        private readonly Keyboard keyboard;
        private int tritiumLocation;
        private Label debugText;
        
        public Refuel(Keyboard keyboard, Label debugText, int tritiumLocation = 0) {
            this.keyboard = keyboard;
            this.debugText = debugText;
            this.tritiumLocation = tritiumLocation;
        }
        
        public void Perform() {
        }
    }
}
