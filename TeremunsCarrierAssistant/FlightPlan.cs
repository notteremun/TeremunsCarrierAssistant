using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TeremunsCarrierAssistant {
    public class FlightPlan {

        public List<string> SystemName = new List<string>(); 
        public List<string> Distance = new List<string>(); 
        public List<string> DistanceRemaining = new List<string>(); 
        public List<string> TritiumTank = new List<string>(); 
        public List<string> TritiumMarket = new List<string>(); 
        public List<string> FuelUsed = new List<string>(); 
        public List<string> IcyRing = new List<string>(); 
        public List<string> Pristine = new List<string>(); 
        public List<string> RestockTritium = new List<string>(); 

        public void ConvertFlightPlan(OpenFileDialog file) {
            using(var reader = new StreamReader(file.FileName)) {
                while (!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    if (line == null) continue;
                    if (line.Contains(
                        "\"System Name\",\"Distance\",\"Distance Remaining\",\"Tritium in tank\",\"Tritium in market\",\"Fuel Used\",\"Icy Ring\",\"Pristine\",\"Restock Tritium\""
                        )) continue;
                    
                    string[] values = line.Split(',');

                    SystemName.Add(values[0].Trim('"'));
                    Distance.Add(values[1].Trim('"'));
                    DistanceRemaining.Add(values[2].Trim('"'));
                    TritiumTank.Add(values[3].Trim('"'));
                    TritiumMarket.Add(values[4].Trim('"'));
                    FuelUsed.Add(values[5].Trim('"'));
                    IcyRing.Add(values[6].Trim('"'));
                    Pristine.Add(values[7].Trim('"'));
                    RestockTritium.Add(values[8].Trim('"'));
                }
            }
        }
    }
}
