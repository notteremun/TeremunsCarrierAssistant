using System;

namespace TeremunsCarrierAssistant.Events {
    public class CarrierJumpRequestData {
        public DateTime timestamp { get; set; }
        public string @event { get; set; }
        public long CarrierID { get; set; }
        public string SystemName { get; set; }
        public string Body { get; set; }
        public long SystemAddress { get; set; }
        public long BodyID { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}