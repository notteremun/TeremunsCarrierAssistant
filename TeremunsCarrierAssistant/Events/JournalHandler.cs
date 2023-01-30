using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TeremunsCarrierAssistant.Events {
    public class JournalHandler {
        public LocationEventData locationData;
        public FSDJumpData fsdJumpData;
        
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
            }
        }
    }
}