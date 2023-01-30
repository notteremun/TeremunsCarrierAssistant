using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Teremuns_Fleet_Carrier_Navigator;
using Teremuns_Fleet_Carrier_Navigator.FleetCarrier;
using TeremunsCarrierAssistant.Events;
using Timer = System.Timers.Timer;

namespace TeremunsCarrierAssistant {
    public partial class Main : Form {
        private readonly FlightPlan plan = new FlightPlan();
        private JournalHandler journalHandler;
        private readonly OpenFileDialog openFileDialog;
        private readonly string currentUserPath;
        private int currentIndex = 0;
        private Jump jump;
        private Refuel refuel;
        
        static Timer timer;
        static DateTime targetTime;
        public bool isJumping;


        public Main() {
            InitializeComponent();
            currentUserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            
            // Register KeyInputs
            Keyboard vInput = new Keyboard();
            jump = new Jump(vInput);
            refuel = new Refuel(vInput);
            
            UpdateJournal();
            textCurrentLocation.Text = @"Current Location: " + journalHandler.fsdJumpData.StarSystem;
            
            openFileDialog = selectCarrierRoute;
        }
        
        // Teremun Methods
        public void Assistant() {
            if (isPlayerInSystem()) currentIndex++;
            Clipboard.SetText(plan.SystemName[currentIndex]);
            jump.Perform();
        }

        public bool isPlayerInSystem() {
            return journalHandler.locationData.StarSystem.Equals(plan.SystemName[currentIndex] + 1);
        }
       
        
        public void UpdateJournal() {
            DirectoryInfo dirInfo = new DirectoryInfo($"{currentUserPath}\\Saved Games\\Frontier Developments\\Elite Dangerous\\");
            FileInfo file = (from f in dirInfo.GetFiles("*.log") orderby f.LastWriteTime descending select f).First();

            string original = $"{currentUserPath}\\Saved Games\\Frontier Developments\\Elite Dangerous\\" + file;
            string copy = $"{currentUserPath}\\Saved Games\\Frontier Developments\\Elite Dangerous\\logCopy.teremun";
            
            try {  
                File.Copy(original, copy, true);  
            } catch (IOException e) { 
                Console.WriteLine(e);
            }

            journalHandler = new JournalHandler(copy);
        }
        
        // Form Event Handlers
        private void btnOpenFileDialog_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog(this);
            plan.ConvertFlightPlan(openFileDialog);

            foreach (string system in plan.SystemName.ToArray()) listJumps.Items.Add(system);
        }
        private void tick_Elapsed(object sender, ElapsedEventArgs e) {
            UpdateJournal();
            textCurrentLocation.Text = @"Current Location: " + journalHandler.locationData.StarSystem;
            // TODO: Add Method to add an Interaction
        }
        private void btnStart_Click(object sender, EventArgs e) {
            jump.Perform();
        }
    }
}
