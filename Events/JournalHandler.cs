using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TeremunsCarrierAssistant.Events {
    public class JournalHandler {
        public readonly LocationEventData locationData;
        public readonly FSDJumpData fsdJumpData;
        public readonly CarrierJumpRequestData carrierJumpRequestData;
        
        public JournalHandler(string dataPath) {
            fsdJumpData = new FSDJumpData();
            fsdJumpData.StarSystem = "Jump Data Available";
            
            List<string> jsonList = new List<string>();

            using (var reader = new StreamReader(dataPath)) {
                while (!reader.EndOfStream) {
                    jsonList.Add(reader.ReadLine());
                }
            }

            foreach(string jsonObj in jsonList) { 
                if (jsonObj.Contains("\"event\":\"Location\"")) { locationData = JsonConvert.DeserializeObject<LocationEventData>(jsonObj); }
                if (jsonObj.Contains("\"event\":\"FSDJump\"")) { fsdJumpData = JsonConvert.DeserializeObject<FSDJumpData>(jsonObj); }
                if (jsonObj.Contains("\"event\":\"CarrierJumpRequest\"")) { carrierJumpRequestData = JsonConvert.DeserializeObject<CarrierJumpRequestData>(jsonObj); }
            }
        }
    }
}