using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using Newtonsoft.Json;

namespace TeremunsCarrierAssistant.Events {
    public class JournalHandler {
        public readonly LocationEventData locationData;
        public readonly FSDJumpData fsdJumpData;
        public readonly CarrierJumpRequestData carrierJumpRequestData;
        private readonly SoundPlayer player = new SoundPlayer();
        
        public JournalHandler(string dataPath) {
            fsdJumpData = new FSDJumpData {
                StarSystem = "STAR SYSTEM"
            };

            List<string> jsonList = new List<string>();

            try {
                using (var reader = new StreamReader(dataPath)) {
                    while (!reader.EndOfStream) {
                        jsonList.Add(reader.ReadLine());
                    }

                    //This should fix random access crashes
                    reader.Close();
                }
            }
            catch (Exception e) {
                player.SoundLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"./../../shutdown_error.wav");
                player.PlaySync();
            }


            foreach(string jsonObj in jsonList) { 
                if (jsonObj.Contains("\"event\":\"Location\"")) { locationData = JsonConvert.DeserializeObject<LocationEventData>(jsonObj); }
                if (jsonObj.Contains("\"event\":\"FSDJump\"")) { fsdJumpData = JsonConvert.DeserializeObject<FSDJumpData>(jsonObj); }
                if (jsonObj.Contains("\"event\":\"CarrierJumpRequest\"")) { carrierJumpRequestData = JsonConvert.DeserializeObject<CarrierJumpRequestData>(jsonObj); }
            }
            player.SoundLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"./../../dial_chevron_beep2.wav");
            player.PlaySync();
            
        }
    }
}