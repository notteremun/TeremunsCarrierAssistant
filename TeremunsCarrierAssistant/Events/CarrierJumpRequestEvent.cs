using System;

namespace TeremunsCarrierAssistant.Events {
    public class CarrierJumpRequestData {
        public DateTime timestamp { get; set; }
        public string @event { get; set; }
        public int CarrierID { get; set; }
        public string SystemName { get; set; }
        public string Body { get; set; }
        public int SystemAddress { get; set; }
        public int BodyID { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}