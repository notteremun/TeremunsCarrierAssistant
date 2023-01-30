using WindowsInput.Native;

namespace TeremunsCarrierAssistant.FleetCarrier {
    
    public class Refuel {
        private readonly Keyboard keyboard;
        private int tritiumLocation;
        
        public Refuel(Keyboard keyboard, int tritiumLocation = 0) {
            this.keyboard = keyboard;
            this.tritiumLocation = tritiumLocation;
        }
    }
}
