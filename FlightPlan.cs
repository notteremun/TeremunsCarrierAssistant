using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TeremunsCarrierAssistant {
    public class FlightPlan {

        public readonly List<string> SystemName        = new List<string>(); 
        public readonly List<double> Distance          = new List<double>(); 
        public readonly List<double> DistanceRemaining = new List<double>(); 
        public readonly List<int>    TritiumTank       = new List<int>(); 
        public readonly List<int>    TritiumMarket     = new List<int>(); 
        public readonly List<int>    FuelUsed          = new List<int>(); 
        public readonly List<string> IcyRing           = new List<string>(); 
        public readonly List<string> Pristine          = new List<string>(); 
        public readonly List<string> RestockTritium    = new List<string>(); 

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
                    Distance.Add( Math.Round(Convert.ToDouble(values[1].Trim('"').Replace('.', ',')), 2));
                    DistanceRemaining.Add(Math.Round(Convert.ToDouble(values[2].Trim('"').Replace('.', ',')), 2));
                    if(values[3].Trim('"') != String.Empty) TritiumTank.Add(Convert.ToInt32(values[3].Trim('"')));
                    TritiumMarket.Add(Convert.ToInt32(values[4].Trim('"')));
                    FuelUsed.Add(Convert.ToInt32(values[5].Trim('"')));
                    IcyRing.Add(values[6].Trim('"'));
                    Pristine.Add(values[7].Trim('"'));
                    RestockTritium.Add(values[8].Replace("\"", ""));
                }
            }
        }
    }
}
